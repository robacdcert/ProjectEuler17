using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler17
{
    public static class WordsClass
    {
        public static string DigitsToWords(int[] input)
        {
            int thousands = input[0]; int hundreds = input[1]; int tens = input[2]; int ones = input[3];
            string thousandsString = ""; string hundredsString = ""; string tensString = ""; string onesString = "";
            string toWords = ""; string conjunction = "and";

            #region Thousands to string
            if (thousands == 1)
            {
                thousandsString = "onethousand";
            }
            if (thousands == 2)
            {
                thousandsString = "twothousand";
            }
            if (thousands == 3)
            {
                thousandsString = "threethousand";
            }
            if (thousands == 4)
            {
                thousandsString = "fourthousand";
            }
            if (thousands == 5)
            {
                thousandsString = "fivethousand";
            }
            if (thousands == 6)
            {
                thousandsString = "sixthousand";
            }
            if (thousands == 7)
            {
                thousandsString = "seventhousand";
            }
            if (thousands == 8)
            {
                thousandsString = "eightthousand";
            }
            if (thousands == 9)
            {
                thousandsString = "ninethousand";
            }
            #endregion

            #region Hundreds to string
            if (hundreds == 1)
            {
                hundredsString = "onehundred";
            }
            if (hundreds == 2)
            {
                hundredsString = "twohundred";
            }
            if (hundreds == 3)
            {
                hundredsString = "threehundred";
            }
            if (hundreds == 4)
            {
                hundredsString = "fourhundred";
            }
            if (hundreds == 5)
            {
                hundredsString = "fivehundred";
            }
            if (hundreds == 6)
            {
                hundredsString = "sixhundred";
            }
            if (hundreds == 7)
            {
                hundredsString = "sevenhundred";
            }
            if (hundreds == 8)
            {
                hundredsString = "eighthundred";
            }
            if (hundreds == 9)
            {
                hundredsString = "ninehundred";
            }
            #endregion

            #region Tens and ones to string
            if (tens == 1)
            {
                int tensPlusOnes = (tens * 10) + ones;
                if (tensPlusOnes == 10)
                {
                    tensString = "ten";
                    ones = 0;
                }
                if (tensPlusOnes == 11)
                {
                    tensString = "eleven";
                    ones = 0;
                }
                if (tensPlusOnes == 12)
                {
                    tensString = "twelve";
                    ones = 0;
                }
                if (tensPlusOnes == 13)
                {
                    tensString = "thirteen";
                    ones = 0;
                }
                if (tensPlusOnes == 14)
                {
                    tensString = "fourteen";
                    ones = 0;
                }
                if (tensPlusOnes == 15)
                {
                    tensString = "fifteen";
                    ones = 0;
                }
                if (tensPlusOnes == 16)
                {
                    tensString = "sixteen";
                    ones = 0;
                }
                if (tensPlusOnes == 17)
                {
                    tensString = "seventeen";
                    ones = 0;
                }
                if (tensPlusOnes == 18)
                {
                    tensString = "eighteen";
                    ones = 0;
                }
                if (tensPlusOnes == 19)
                {
                    tensString = "nineteen";
                    ones = 0;
                }
            }
            #endregion

            #region Tens to string
            if (tens == 2)
            {
                tensString = "twenty";
            }
            if (tens == 3)
            {
                tensString = "thirty";
            }
            if (tens == 4)
            {
                tensString = "forty";
            }
            if (tens == 5)
            {
                tensString = "fifty";
            }
            if (tens == 6)
            {
                tensString = "sixty";
            }
            if (tens == 7)
            {
                tensString = "seventy";
            }
            if (tens == 8)
            {
                tensString = "eighty";
            }
            if (tens == 9)
            {
                tensString = "ninety";
            }
            #endregion

            #region Ones to string
            if (ones == 1)
            {
                onesString = "one";
            }
            if (ones == 2)
            {
                onesString = "two";
            }
            if (ones == 3)
            {
                onesString = "three";
            }
            if (ones == 4)
            {
                onesString = "four";
            }
            if (ones == 5)
            {
                onesString = "five";
            }
            if (ones == 6)
            {
                onesString = "six";
            }
            if (ones == 7)
            {
                onesString = "seven";
            }
            if (ones == 8)
            {
                onesString = "eight";
            }
            if (ones == 9)
            {
                onesString = "nine";
            }
            #endregion

            toWords = thousandsString + hundredsString;
            if ((thousands != 0 || hundreds != 0) && (ones != 0 || tens != 0))
            {
                toWords = toWords + conjunction;
            }
            toWords = toWords + tensString + onesString;

            return toWords;
        }
    }
}
