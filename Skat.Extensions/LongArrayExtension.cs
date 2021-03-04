using System.Collections.Generic;
using System.Linq;

namespace Skat.Extensions
{
    public static class LongArrayExtension
    {
        /// <summary>
        /// Given an array of long numbers, returns its maximum common divider
        /// </summary>
        /// <param name="numbers">Numbers to check</param>
        /// <returns>
        /// MCD from its decomposition
        /// </returns>
        public static long MaximumCommonDivider(this long[] numbers)
        {
            var intermediate = GetDecomposedArray(numbers);
            long result = 1;
            List<long> data = intermediate.Common.Count > 0 ? intermediate.Common : intermediate.All;

            foreach (long n in data)
            {
                result *= n;
            }

            return result;
        }

        /// <summary>
        /// Given an array of long numbers, returns its minimum common multiple
        /// </summary>
        /// <param name="numbers">Numbers to check</param>
        /// <returns>
        /// MCM from its decomposition
        /// </returns>
        public static long MinimumCommonMultiple(this long[] numbers)
        {
            var intermediate = GetDecomposedArray(numbers);
            long result = 1;
            foreach (long n in intermediate.All)
            {
                result *= n;
            }

            return result;
        }

        /// <summary>
        /// Given an array of long, returns its cannonical decomposition
        /// </summary>
        /// <param name="numbers">Numbers to decompose</param>
        /// <returns>
        /// List of decomposition numbers
        /// </returns>
        public static List<long> Decompose(this long[] numbers)
        {
            return GetDecomposedArray(numbers).All;
        }

        /// <summary>
        /// Decomposes an array of long numbers
        /// </summary>
        /// <param name="number">Numbers to test</param>
        /// <returns>
        /// All -> All decomposition values
        /// Common -> Only the decomposition values that were divisible by whole line
        /// </returns>
        private static DecompositionResult GetDecomposedArray(long[] number)
        {
            long[] clone = (long[])number.Clone();
            DecompositionResult result = new DecompositionResult();
            long prime = 2;

            while (clone.Any(x => x > 1))
            {
                bool isDivisible = false;
                bool allDivisible = true;
                for (int i = 0; i < clone.Count(); i++)
                {
                    long q = clone[i];
                    if (q % prime == 0)
                    {
                        isDivisible = true;
                        q /= prime;
                    }
                    else
                    {
                        allDivisible = false;
                    }
                    clone[i] = q;
                }

                if (allDivisible)
                {
                    result.Common.Add(prime);
                }

                if (isDivisible)
                {
                    result.All.Add(prime);
                }
                else
                {
                    prime = prime.NextPrime();
                }
            }

            return result;
        }


        /// <summary>
        /// Support class
        /// </summary>
        class DecompositionResult
        {
            public DecompositionResult()
            {
                All = new List<long>();
                Common = new List<long>();
            }
            public List<long> All;
            public List<long> Common;
        }
    }


}
