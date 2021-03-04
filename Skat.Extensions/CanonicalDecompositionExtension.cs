using System.Collections.Generic;

namespace Skat.Extensions
{
    public static class CanonicalDecompositionExtension
    {

        public static List<long> Decompose(this long number)
        {
            return DecomposeNumber(number);
        }

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
