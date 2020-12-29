using System;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using TrellisControl.ApplicationCore;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using TrellisControl.Dialogs;
using System.Linq;
using System.Diagnostics;
using System.Threading;

namespace TrellisControl
{
    public partial class Form1 : Form
    {

        private ConfigurationMap trellisConfiguration;
        private SerialPort trellisPort;

        public Form1()
        {
            InitializeComponent();
            LoadTrellisConfig();

            trellisComSelection.ComboBox.SelectionChangeCommitted += ComboBox_SelectionChangeCommitted;
            trellisAutoConnect.CheckedChanged += TrellisAutoConnect_CheckedChanged;
            trellisConnectSerial.Click += TrellisConnectSerial_Click;
            trellisSetAllColors.Click += TrellisSetAllColors_Click;
            setNeoTrellisBrightness.Click += TrellisBrightnessControl_Click;

            trellisAutoConnect.Checked = Trellis.Default.AutoConnect;
            trellisSerialStatusLabel.Text = "Status: Disconnected";



            string[] ports = SerialPort.GetPortNames();
            trellisComSelection.Items.AddRange(ports);
            var savedPort = Trellis.Default.ComPortName;
            if (!savedPort.IsNullWhitespaceOrEmpty())
            {
                if(trellisComSelection.Items.Contains(savedPort))
                {
                    trellisComSelection.SelectedItem = savedPort;
                    trellisComSelection.Text = savedPort;
                    trellisPort = new SerialPort(trellisComSelection.Text)
                    {
                        BaudRate = 115200,
                        DtrEnable = true,
                        RtsEnable = true,
                        Handshake = Handshake.None,
                        StopBits = StopBits.One,

                    };
                    if (Trellis.Default.AutoConnect)
                    {
                        trellisConnectSerial.PerformClick();
                    }
                }
            }
            else
            {
                trellisPort = new SerialPort()
                {
                    BaudRate = 115200,
                    DtrEnable = true,
                    RtsEnable = true,
                    Handshake = Handshake.None,
                    StopBits = StopBits.One,

                };
            }
        }

        private void TrellisBrightnessControl_Click(object sender, EventArgs e)
        {
            var brightnessControlDialog = new TrellisBrightnessControl(this.trellisConfiguration.Brightness);
            if(brightnessControlDialog.ShowDialog() == DialogResult.OK)
            {
                this.trellisConfiguration.Brightness = brightnessControlDialog.Brightness;
                var trellisCommand = string.Format(CommandStrings.SetBrightness, brightnessControlDialog.Brightness);
                SendTrellisControlMessage(trellisCommand);
                SaveTrellisConfig();
            }    
        }

        private void TrellisSetAllColors_Click(object sender, EventArgs e)
        {
            ColorDialog trellisColorDialog = new ColorDialog()
            {
                AllowFullOpen = true,
                AnyColor = true
            };

            if(trellisColorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach(var buttonConfig in this.trellisConfiguration.Buttons)
                {
                    buttonConfig.neoPixelColor = trellisColorDialog.Color;
                }
                
                foreach(var control in this.Controls)
                {
                    if(control.GetType() == typeof(Button))
                    {
                        var button = (Button)control;
                        if (button.Tag.ToString().Contains("Button"))
                        {
                            button.BackColor = trellisColorDialog.Color;
                        }
                    }
                }

                var controlMessage = string.Format(CommandStrings.SetAllKeys, trellisColorDialog.Color.R, trellisColorDialog.Color.G, trellisColorDialog.Color.B);
                SendTrellisControlMessage(controlMessage);

                SaveTrellisConfig();
            }
        }

        private void TrellisDisconnectSerial_Click(object sender, EventArgs e)
        {
            if(trellisPort.IsOpen)
            {
                trellisPort.Close();
                trellisConnectSerial.Click -= TrellisDisconnectSerial_Click;
                trellisConnectSerial.Click += TrellisConnectSerial_Click;
                trellisConnectSerial.Text = "Connect";
                trellisComSelection.Enabled = true;
            }
        }

        private void TrellisConnectSerial_Click(object sender, EventArgs e)
        {
            if(!trellisComSelection.Text.IsNullWhitespaceOrEmpty())
            {                
                try
                {
                    trellisPort.Open();
                    if(trellisPort.IsOpen)
                    {
                        trellisPort.DataReceived += TrellisPort_DataReceived;
                        trellisConnectSerial.Click -= TrellisConnectSerial_Click;
                        trellisConnectSerial.Click += TrellisDisconnectSerial_Click;
                        trellisConnectSerial.Text = "Disconnect";
                        trellisComSelection.Enabled = false;
                        trellisSerialStatusLabel.Text = "Status: Connected";
                    }
                }
                catch(Exception ex)
                {
                    trellisSerialStatusLabel.Text = $"Status: {ex.Message}";
                }
            }
        }

        private void TrellisButton_Click(object sender, EventArgs e)
        {
            var trellisButton = (Button)sender;
            var buttonTagNumber = int.Parse(trellisButton.Tag.ToString().Replace("Button", ""));
            var buttonConfigurationDialog = new ButtonConfiguration(this.trellisConfiguration.Buttons[buttonTagNumber - 1]);
            if (buttonConfigurationDialog.ShowDialog() == DialogResult.OK)
            {
                this.trellisConfiguration.Buttons[buttonTagNumber - 1] = buttonConfigurationDialog.ButtonConfigurationMap;
                var newButtonColor = buttonConfigurationDialog.ButtonConfigurationMap.neoPixelColor;
                trellisButton.BackColor = newButtonColor;
                SaveTrellisConfig();

                // Send color config to trellis
                var commandMessage = string.Format(CommandStrings.SetKeyColor, buttonTagNumber, newButtonColor.R, newButtonColor.G, newButtonColor.B);
                SendTrellisControlMessage(commandMessage);
            }
        }

        private void TrellisPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var trellisPort = sender as SerialPort;
            int numbytes = trellisPort.BytesToRead;
            byte[] bytes = new byte[numbytes];
            if (numbytes > 0)
            {
                _ = trellisPort.Read(bytes, 0, numbytes);
            }

            var payload = Encoding.UTF8.GetString(bytes).Replace("\r", "").Replace("\n", "");
            var validInteger = int.TryParse(payload, out var buttonAction);
            if (validInteger)
            {
                var button = trellisConfiguration.Buttons[buttonAction];
                switch (button.actionType)
                {
                    case ActionType.None:
                        break;
                    case ActionType.Executable:
                        if(!button.executablePath.IsNullWhitespaceOrEmpty())
                        {
                            Process.Start(button.executablePath);
                        }
                        break;
                }
            }
            else
            {
                if (payload == "CommandReady")
                {
                    var brightnessCommand = string.Format(CommandStrings.SetBrightness, this.trellisConfiguration.Brightness);
                    SendTrellisControlMessage(brightnessCommand);
                    for(int i = 0; i < this.trellisConfiguration.NumberOfButtons; i++)
                    {
                        var buttonColor = this.trellisConfiguration.Buttons[i].neoPixelColor;
                        var commandMessage = string.Format(CommandStrings.SetKeyColor, i, buttonColor.R, buttonColor.G, buttonColor.B);
                        SendTrellisControlMessage(commandMessage);
                        Thread.Sleep(500); // Give it a half second to recover from the previous message, can make longer if needed.
                    }
                }
              
            }
        }

        private void TrellisAutoConnect_CheckedChanged(object sender, EventArgs e)
        {
            Trellis.Default.AutoConnect = trellisAutoConnect.Checked;
            Trellis.Default.Save();
        }

        private void ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            trellisPort.PortName = trellisComSelection.ComboBox.SelectedItem.ToString();
            Trellis.Default.ComPortName = trellisComSelection.ComboBox.SelectedItem.ToString();
            Trellis.Default.Save();
        }

        private void LoadTrellisConfig()
        {
            var trellisConfigPath = $@"{Environment.CurrentDirectory}\ButtonMappings.json";
            this.trellisConfiguration = JsonConvert.DeserializeObject<ConfigurationMap>(File.ReadAllText(trellisConfigPath));
            if (!this.trellisConfiguration.FirstConfigured)
            {
                GenerateTrellisConfig(trellisConfigPath);
            }
            else
            {
                List<Button> buttons = this.Controls.OfType<Button>().ToList();
                buttons = buttons.Where(x => x.Tag.ToString().Contains("Button")).ToList();
                foreach (var button in buttons)
                {
                    button.BackColor = this.trellisConfiguration.Buttons[int.Parse(button.Tag.ToString().Replace("Button", "")) - 1].neoPixelColor;
                }
            }
        }

        private void GenerateTrellisConfig(string trellisConfigPath)
        {
            var numberOfButtons = 32; // Load this from the trellis eventually;
            var buttonConfigList = new List<ButtonConfigurationMap>();
            for(int i = 0; i < numberOfButtons; i++)
            {
                buttonConfigList.Add(new ButtonConfigurationMap()
                {
                    actionType = ActionType.None,
                    neoPixelColor = Color.Red
                });
            }

            var newConfig = new ConfigurationMap()
            {
                NumberOfButtons = numberOfButtons,
                FirstConfigured = true,
                Buttons = buttonConfigList,
                Brightness = 80
            };

            this.trellisConfiguration = newConfig;
            List<Button> buttons = this.Controls.OfType<Button>().ToList();
            buttons = buttons.Where(x => x.Tag.ToString().Contains("Button")).ToList();
            foreach(var button in buttons)
            {
                button.BackColor = newConfig.Buttons[int.Parse(button.Tag.ToString().Replace("Button", "")) - 1].neoPixelColor;
            }

            File.WriteAllText(trellisConfigPath, JsonConvert.SerializeObject(newConfig));
        }

        private void SaveTrellisConfig()
        {
            var trellisConfigPath = $@"{Environment.CurrentDirectory}\ButtonMappings.json";
            File.WriteAllText(trellisConfigPath, JsonConvert.SerializeObject(this.trellisConfiguration));
        }

        private void SendTrellisControlMessage(string controlMessage)
        {
            if(trellisPort != null && trellisPort.IsOpen)
            {
                trellisPort.WriteLine(controlMessage);
            }
        }
    }
}
