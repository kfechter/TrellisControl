using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrellisControl.Dialogs
{
    public partial class TrellisBrightnessControl : Form
    {
        public int Brightness { get; set; }
        public TrellisBrightnessControl(int brightness)
        {
            InitializeComponent();
            this.Brightness = brightness;
            neotrellisBrightnessControl.Value = brightness;
        }

        private void neotrellisBrightnessControl_ValueChanged(object sender, EventArgs e)
        {
            brightnessValueLabel.Text = $"Brightness: {neotrellisBrightnessControl.Value}";
            this.Brightness = neotrellisBrightnessControl.Value;
        }
    }
}
