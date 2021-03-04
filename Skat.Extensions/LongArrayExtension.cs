using System.Collections.Generic;
using System.Linq;

namespace Skat.Extensions
{
    public static class LongArrayExtension
    {
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

        public static List<long> Decompose(this long[] numbers)
        {
            return GetDecomposedArray(numbers).All;
        }

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
