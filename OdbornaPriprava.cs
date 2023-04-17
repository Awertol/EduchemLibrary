using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Educhem
{
 

    public static partial class OdbornaPriprava
    {
        
        public static string OrganizaceKabelu(string nazevKonektoru)
        {
            string vysledek = "";
            if (nazevKonektoru == "RJ11")
                {
                 vysledek = "KRBY";

            }
            else if (nazevKonektoru == "RJ12")
            {
                 vysledek = "UKRGYB";

            }
            else if (nazevKonektoru == "RJ45")
            {
                 vysledek = "NBOG";
            }
            return vysledek;
        }
        

    }
    
}