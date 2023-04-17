namespace Educhem {
    public static partial class Matematika {
        /// <summary>
        /// Zjistí jestli je trojúhelník pravoúhlý
        /// </summary>
        /// <returns>true jestli je trojúhelník pravoúhlý, false pokud není</returns>
        public static bool JePravouhly(double triangleX, double triangleY, double triangleZ) {
            double s = MathF.Asin((float)(triangleX / triangleZ));
            double d = MathF.Asin((float)(triangleY / triangleZ));

            return Math.Floor((s + d) * 180 / Math.PI) == 90;
        }
    }
}