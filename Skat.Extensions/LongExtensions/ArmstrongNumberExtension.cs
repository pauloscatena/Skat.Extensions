using System;
using System.Collections.Generic;

namespace Skat.Extensions.LongExtensions
{
    public static class ArmstrongNumberExtension
    {
        /// <summary>
        /// Check if number is an Armstrong Number (sum of cubes of its digits)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsArmstrongNumber(this long number)
        {
            var digits = number.ExtractDigits();
            long sum = 0;
            foreach (var i in digits)
            {
                sum += (long)Math.Pow(i, 3);
            }

            return sum == number;
        }

        /// <summary>
        /// Return all Armstrong Numbers less than given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<long> GetArmstrongNumbers(this long number)
        {
            List<long> result = new List<long>();
            for (long i = 0; i < number; i++)
            {
                if (i.IsArmstrongNumber())
                    result.Add(i);
            }
            return result;
        }
    }
}
