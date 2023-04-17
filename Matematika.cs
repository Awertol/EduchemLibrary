using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educhem
{
    public static partial class Matematika
    {
        public static int priklad()
        {
            int polomer = 2;
            int rNaDruhou = polomer * polomer;
            int vyska = 5;
            double vysledek = Math.PI * rNaDruhou * vyska;
            return priklad();
        }
    }
}