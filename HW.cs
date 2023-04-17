using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educhem
{
    public static partial class HW
    {
        public static double Pomer (double sirka, double vyska, double fin)
        {
            fin = sirka / vyska;
            fin = Math.Round(fin, 2);
            return fin;
        }
    }
}
