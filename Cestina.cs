using System.Linq;

namespace Educhem;

public static partial class Cestina{
    public static int NumberOfVowels(this string input){
        string[] Vowels = new[]{
            "A", "E", "I", "O", "U",
            "Á", "É", "Í", "Ó", "Ú",
            "Y", "Ý", "Ů"
        };

        return input.Count(x => Vowels.Any(y => y == x.ToString()));
    }
}