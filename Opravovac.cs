namespace Educhem
{
    public class Predmet
    {
        public static partial class Cestina
        {
            public static string Opravovac(string a)
            {
                string first = a.Substring(0, 1);
                a.Substring(0, 1).Replace(a.Substring(0, 1), first.ToUpper());
                a += "!";
                return a;
            }
        }
    }
}