using System;
using System.Collections.Generic;

namespace Skat.Extensions
{
    public static class ArmstrongNumberExtension
    {
        public static bool IsArmstrongNumber(this long number)
        {
            var digits = number.ExtractDigits();
            double sum = 0;
            foreach(long i in digits)
            {
                sum += Math.Pow(i, 3);
            }

            return sum == number;
        }

        public static List<long> GetArmstrongNumbers(this long number)
        {
            List<long> result = new List<long>();
            for(long i = 0; i < number; i++)
            {
                if (i.IsArmstrongNumber())
                    result.Add(i);
            }
            return result;
        }
    }
}
