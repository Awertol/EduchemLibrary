using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Educhem
{
    public static partial class Matematika
    {
        private static string owo = "";
        public static string prvo_cislo(int cislo)
        {
            bool prvocislo = false;            

            if (cislo <= 2)
            {
                prvocislo = true;
                return owo = prvocislo.ToString();
            }           
            else if (cislo % 2 == 0)
            {
                prvocislo = true;
                return owo = prvocislo.ToString();                
            }           
            else
            {
                prvocislo = false;
                return owo = prvocislo.ToString();
            }
        }
    }
}
