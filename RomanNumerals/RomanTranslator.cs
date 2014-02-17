using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanTranslator
    {
        static Dictionary<int, String> valueMap = new Dictionary<int, String>()
        {
            {10, "X"},
            {5, "V"}
        };

        public static String translate(int arabicNumber)
        {
            string romanResult = string.Empty;
            if (arabicNumber <= 3)
            {
                romanResult = stringI(arabicNumber);
            }
            else if (arabicNumber >= 9)
            {
                romanResult = concatI(arabicNumber, romanResult, 10);
            }
            else
            {
                romanResult = concatI(arabicNumber, romanResult, 5);
            }

            return romanResult;
        }

        private static string concatI(int arabicNumber, string romanResult, int palier)
        {
            if (arabicNumber == palier - 1 || arabicNumber == palier-1)
            {
                romanResult = "I";
            }
            romanResult += valueMap[palier];
            romanResult += stringI(arabicNumber - palier);
            return romanResult;
        }

        private static string stringI(int arabicNumber)
        {

            string romanResult = string.Empty;
            for (int i = 0; i < arabicNumber; i++)
            {
                romanResult += "I";
            }
            return romanResult;
        }
    }
}
