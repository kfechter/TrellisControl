using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrellisControl.ApplicationCore;

namespace TrellisControl.Dialogs
{
    public partial class ButtonConfiguration : Form
    {
        public ButtonConfigurationMap ButtonConfigurationMap { get; set; } 

        public ButtonConfiguration(ButtonConfigurationMap buttonConfigurationMap)
        {
            InitializeComponent();
            this.ButtonConfigurationMap = buttonConfigurationMap;
            trellisButtonColor.BackColor = buttonConfigurationMap.neoPixelColor;
            executablePath.Text = this.ButtonConfigurationMap.executablePath;
            SetControlVisibility(this.ButtonConfigurationMap.actionType);
        }

        private void trellisButtonColor_Click(object sender, EventArgs e)
        {
            ColorDialog buttonColorPicker = new ColorDialog
            {
                AllowFullOpen = true,
                AnyColor = true
            };
            if (buttonColorPicker.ShowDialog() == DialogResult.OK)
            {
                this.ButtonConfigurationMap.neoPixelColor = buttonColorPicker.Color;
                trellisButtonColor.BackColor = buttonColorPicker.Color;
            }
        }

        private void trellisButtonAction_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch(trellisButtonAction.SelectedItem.ToString())
            {
                case "None":
                    this.ButtonConfigurationMap.actionType = ActionType.None;
                    break;
                case "Executable":
                    this.ButtonConfigurationMap.actionType = ActionType.Executable;
                    break;
            }
            SetControlVisibility(this.ButtonConfigurationMap.actionType);
        }

        private void SetControlVisibility(ActionType actionType)
        {
            switch(actionType)
            {
                case ActionType.None:
                    executableBrowseButton.Visible = false;
                    executablePath.Visible = false;
                    executablePathLabel.Visible = false;
                    break;
                case ActionType.Executable:
                    executableBrowseButton.Visible = true;
                    executablePath.Visible = true;
                    executablePathLabel.Visible = true;
                    break;
            }
        }
    }
}
