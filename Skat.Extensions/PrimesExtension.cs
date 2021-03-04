using System;

namespace Skat.Extensions
{
    public static class PrimesExtension
    {
        public static bool IsPrime(this long number)
        {
            return checkPrime(number);
        }

        public static long NextPrime(this long number)
        {
            return GetNextPrime(number);
        }

        private static bool checkPrime(long number)
        {
            bool result = true;

            result = CheckPrimeEnding(number);
            if (result)
            {
                result = CheckPrimeDivision(number);
            }

            return result;
        }

        private static long GetNextPrime(long number)
        {
            long next = number + 1;
            while(!next.IsPrime())
            {
                next++;
            }
            return next;
        }

        private static bool CheckPrimeDivision(long number)
        {
            bool result = true;
            long check = number / 2;

            while (result && check > 1)
            {
                if(number % check == 0)
                {
                    result = false;
                }
                check--;
            }

            return result;
        }

        /// <summary>
        /// Check last digit of a number to check if it can be prime.
        /// Logic: We can exclude all numbers greater than 9 that finishes in 0, 2, 4, 5, 6, 8. They will be divisible by 2 or 5, always
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static bool CheckPrimeEnding(long number)
        {
            if(number > 9)
            {
                var lastDigit = number % 10;
                return lastDigit == 1 || lastDigit == 3 || lastDigit == 7 || lastDigit == 9;
            }
            return true;
        }
    }
}
