using System;
using System.Collections.Generic;

namespace Skat.Extensions.LongExtensions
{
    public static class NumberDigitExtension
    {
        /// <summary>
        /// Extract number digits respecting its positions
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<long> ExtractDigits(this long number)
        {
            List<long> result = new List<long>();
            long aux = number < 0 ? number * -1: number;

            while (aux > 0)
            {
                var reminder = aux % 10;
                result.Add(reminder);
                aux /= 10;
            }

            return result;
        }
    }
}
