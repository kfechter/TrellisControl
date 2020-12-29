using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrellisControl.ApplicationCore
{
    public enum ActionType
    {
        None,
        Executable
   // , KeyPress 
    }

    public class ButtonConfigurationMap
    {
        public int ButtonNumber { get; set; }

        public Color neoPixelColor { get; set; }

        public string executablePath { get; set; }

        public ActionType actionType { get; set; }
    }
}
