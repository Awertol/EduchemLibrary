using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educhem
{
    public static partial class OdbornaPriprava
    {
        public static Dictionary<string, string> Kovy = new Dictionary<string, string>()
        {
            {"Au", "19,3 g/cm³" },
            {"Ag", "10,49 g/cm³" },
            {"Cu", "8,96 g/cm³" },
            {"Fe", "7,86 g/cm³" }
        };
        public static string ChemPrvek(string prvek)
        {
            return(Kovy.GetValueOrDefault(prvek) ?? "neplatná hodnota");
        } 
    }

    
}
