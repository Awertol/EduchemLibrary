using System.Drawing;

namespace Educhem{
    public static partial class Grafika{

            private static int MIN_COLOR_VALUE = 0;
            private static int MAX_COLOR_VALUE = 255;
            private static Random random;

            public static Color RGBColorGenerator()
            {
                int red = random.Next(MIN_COLOR_VALUE, MAX_COLOR_VALUE + 1);
                int green = random.Next(MIN_COLOR_VALUE, MAX_COLOR_VALUE + 1);
                int blue = random.Next(MIN_COLOR_VALUE, MAX_COLOR_VALUE + 1);
                return Color.FromArgb (red, green, blue);
            }
    }
}