using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler17
{
    public static class ArrayClass
    {
        // Methods
        public static int[] NumberToDigits(int input)
        {
            int[] digits = new int[4] {0, 0, 0, 0};
            int digitPlace = 3;
            while (input > 0)
            {
                int x = input % 10;
                digits[digitPlace] = x;
                input = input / 10;
                digitPlace--;
            }
            return digits;
        }
    }
}
