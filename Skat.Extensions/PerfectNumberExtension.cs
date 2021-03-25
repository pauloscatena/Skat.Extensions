using System.Collections.Generic;
using System.Linq;

namespace Skat.Extensions
{
    public static class PerfectNumberExtension
    {
        /// <summary>
        /// Check if a number is perfect (sum of factors equals to number)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPerfectNumber(this long number)
        {
            if (number < 6)
                return false;

            var factors = GetNumberFactors(number);
            return 1 + factors.Sum() == number;
        }


        /// <summary>
        /// Return all perfect numbers less than given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<long> GetPerfectNumbers(this long number)
        {
            List<long> result = new List<long>();
            for (long i = 1; i < number; i++)
            {
                if (i.IsPerfectNumber())
                    result.Add(i);
            }
            return result;
        }

        /// <summary>
        /// Return a list of factors for a number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<long> GetNumberFactors(long number)
        {
            List<long> result = new List<long>();
            for (long i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    result.Add(i);
            }
            return result;
        }

    }
}
