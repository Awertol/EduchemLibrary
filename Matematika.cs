namespace Educhem {
    public static partial class Matematika {
        public static bool JePravouhly(double triangleX, double triangleY, double triangleZ) {
            double s = MathF.Asin((float)(triangleX / triangleZ));
            double d = MathF.Asin((float)(triangleY / triangleZ));

            return Math.Floor((s + d) * 180 / Math.PI) == 90;
        }
    }
}