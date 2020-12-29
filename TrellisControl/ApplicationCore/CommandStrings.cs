using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrellisControl.ApplicationCore
{
    public static class CommandStrings
    {
        public static string SetKeyColor => "SETKEY,{0},{1},{2},{3}";

        public static string SetAllKeys => "SETCOLOR,{0},{1},{2}";

        public static string SetBrightness => "SETBRIGHTNESS,{0}";

        public static string ButtonTagFormat => "Button{0}";
    }
}
