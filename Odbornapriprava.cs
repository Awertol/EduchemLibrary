using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educhem
{
    public static partial class Odbornapriprava
    {
        public static string chemZkratka(string chemZkratka)
        {
            var teploty = new Dictionary<string, string>() {
            {"Au", "1 064 °C"},
                {"Li","180,54 °C"},
                {"Na","97,72 °C"}, 
                {"K","63,38 °C"}
            };
            return teploty[chemZkratka];
        }
    }
}
