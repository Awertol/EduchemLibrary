using System.Collections.Generic;
using System;

namespace Educhem
{
    public static partial class Cestina
    {
        public static string ceskeUzemi(int stoleti)
        {
            Dictionary<int, string> Slovnik = new Dictionary <int, string>();
            Slovnik.Add(1, "říše římská");
            Slovnik.Add(2, "říše římská");
            Slovnik.Add(3, "říše římská");
            Slovnik.Add(4, "říše římská");
            Slovnik.Add(5, "germánské kmeny");
            Slovnik.Add(6, "Velkomoravská říše");
            Slovnik.Add(7, "Velkomoravská říše");
            Slovnik.Add(8, "Velkomoravská říše");
            Slovnik.Add(9, "Velkomoravská říše");
            Slovnik.Add(10, "knížectví české a knížectví moravské");
            Slovnik.Add(11, "knížectví české a knížectví moravské");
            Slovnik.Add(12, "Svatá říše římská");
            Slovnik.Add(13, "Svatá říše římská");
            Slovnik.Add(14, "Svatá říše římská");
            Slovnik.Add(15, "Svatá říše římská");
            Slovnik.Add(16, "Svatá říše římská");
            Slovnik.Add(17, "Svatá říše římská");
            Slovnik.Add(18, "Habsburská monarchie");
            Slovnik.Add(19, "Rakouské císařství,");
            Slovnik.Add(20, "Rakousko-Uhersko");
            Slovnik.Add(21, "Česká Republika");

            string vysledek = Slovnik[stoleti];
            return vysledek;
        }
    }
}