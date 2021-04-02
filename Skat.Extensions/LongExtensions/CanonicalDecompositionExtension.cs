using System.Collections.Generic;

namespace Skat.Extensions.LongExtensions
{
    public static class CanonicalDecompositionExtension
    {
        /// <summary>
        /// Given a number, decomposes it cannonnically
        /// </summary>
        /// <param name="number">Number to decompose</param>
        /// <returns>
        /// List of decomposition numbers
        /// </returns>
        public static List<long> CanonicalDecompose(this long number)
        {
            return DecomposeNumber(number);
        }

        /// <summary>
        /// Given a number, decomposes it cannonnically
        /// </summary>
        /// <param name="number">Number to decompose</param>
        /// <returns>
        /// List of decomposition numbers
        /// </returns>
        private static List<long> DecomposeNumber(long number)
        {
            List<long> result = new List<long>();
            long prime = 2;
            long q = number;
            while (q > 1)
            {
                if (q.IsPrime())
                {
                    result.Add(q);
                    q = 1;
                }
                else
                {
                    if (q % prime == 0)
                    {
                        result.Add(prime);
                        q /= prime;
                    }
                    else
                    {
                        prime = prime.NextPrime();
                    }
                }
            }

            return result;
        }       

    }
}
