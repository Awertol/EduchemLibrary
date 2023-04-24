using System.Drawing;

namespace Educhem1
{
    public static partial class Grafika
    { 
        public static Color vytvorBarvu()
        {
            Random generator = new Random();
            int cislo1 = generator.Next(255);
            int cislo2 = generator.Next(255);
            int cislo3 = generator.Next(255);
            return Color.FromArgb(cislo1, cislo2, cislo3);
        }
    }        
}