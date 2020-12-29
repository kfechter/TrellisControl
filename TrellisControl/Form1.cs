using System;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using TrellisControl.ApplicationCore;
using System.Collections.Generic;

namespace TrellisControl
{
    public partial class Form1 : Form
    {

        private List<ButtonConfigurationMap> ButtonConfigurations;

        public Form1()
        {
            InitializeComponent();
            ButtonConfigurations = new List<ButtonConfigurationMap>();
            // Load from json and do check

            trellisComSelection.ComboBox.SelectionChangeCommitted += ComboBox_SelectionChangeCommitted;
            trellisAutoConnect.CheckedChanged += TrellisAutoConnect_CheckedChanged;
            trellisConnectSerial.Click += TrellisConnectSerial_Click;

            trellisAutoConnect.Checked = Trellis.Default.AutoConnect;

            string[] ports = SerialPort.GetPortNames();
            trellisComSelection.Items.AddRange(ports);
            var savedPort = Trellis.Default.ComPortName;
            if (!savedPort.IsNullWhitespaceOrEmpty())
            {
                if(trellisComSelection.Items.Contains(savedPort))
                {
                    trellisComSelection.SelectedItem = savedPort;
                    trellisComSelection.Text = savedPort;
                }
            }
        }

        private void TrellisConnectSerial_Click(object sender, EventArgs e)
        {
            if(!trellisComSelection.Text.IsNullWhitespaceOrEmpty())
            {
                SerialPort trellisPort = new SerialPort(trellisComSelection.Text)
                {
                    BaudRate = 115200,
                    DtrEnable = true,
                    RtsEnable = true,
                    Handshake = Handshake.None,
                    StopBits = StopBits.One,
                    
                };
                
                try
                {
                    trellisPort.Open();
                    if(trellisPort.IsOpen)
                    {
                        trellisPort.DataReceived += TrellisPort_DataReceived;
                    }
                }
                catch(Exception ex)
                {
                    trellisSerialStatusLabel.Text = $"Status: {ex.Message}";
                }
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

            var message = Encoding.UTF8.GetString(bytes).Replace("\r", "").Replace("\n", "");
            if(!message.IsNullWhitespaceOrEmpty())
            {
                trellisSerialStatusLabel.ToolStripStatusInvokeAction(t =>
                {
                    t.Text = $"Trellis Sent: {message}";
                });
            }
        }

        private void TrellisAutoConnect_CheckedChanged(object sender, EventArgs e)
        {
            Trellis.Default.AutoConnect = trellisAutoConnect.Checked;
            Trellis.Default.Save();
        }

        private void ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Trellis.Default.ComPortName = trellisComSelection.ComboBox.SelectedItem.ToString();
            Trellis.Default.Save();
        }
    }
}
