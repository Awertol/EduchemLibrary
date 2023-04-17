namespace Educhem
{
    public static partial class Hardware
    {
        public static string GetAspectRatio(int width, int height)
        {
            int gcd = GetGCD(width, height);
            return $"{width / gcd}:{height / gcd}";
        }

        public static int GetGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}