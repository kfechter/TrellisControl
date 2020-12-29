using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrellisControl.ApplicationCore
{
    public class ConfigurationMap
    {
        public int NumberOfButtons { get; set; }

        public bool FirstConfigured { get; set; }

        public int Brightness { get; set; }

        public List<ButtonConfigurationMap> Buttons { get; set; }

    }
}
