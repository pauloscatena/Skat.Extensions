using System;

namespace Skat.Extensions
{
    public static class PrimesExtension
    {
        /// <summary>
        /// Given a long, returns if it is prime
        /// </summary>
        /// <param name="number">Number to test</param>
        /// <returns>
        /// True, if prime
        /// False if not prime
        /// </returns>
        public static bool IsPrime(this long number)
        {
            return checkPrime(number);
        }

        /// <summary>
        /// Given a long, returns the next prime number
        /// </summary>
        /// <param name="number">base number</param>
        /// <returns>Next prime number</returns>
        public static long NextPrime(this long number)
        {
            return GetNextPrime(number);
        }

        /// <summary>
        /// Performs all checks to ensure a number is prime
        /// </summary>
        /// <param name="number">Number to test</param>
        /// <returns>
        /// True, if prime
        /// False, if not prime
        /// </returns>
        private static bool checkPrime(long number)
        {
            bool result = true;

            /// Check ending first: this will save time when checking several numbers
            result = CheckPrimeEnding(number);
            if (result)
            {
                result = CheckPrimeDivision(number);
            }

            return result;
        }

        /// <summary>
        /// Given a number, it returns its next prime
        /// </summary>
        /// <param name="number">reference number</param>
        /// <returns>next prime</returns>
        private static long GetNextPrime(long number)
        {
            long next = number + 1;
            while(!next.IsPrime())
            {
                next++;
            }
            return next;
        }

        /// <summary>
        /// Will return if a number is prime by dividing it by possible numbers
        /// Logic: the valid range is between 2 and half of the number. We can disconsider all other numbers
        /// </summary>
        /// <param name="number">number to test</param>
        /// <returns>
        /// True, if prime
        /// False, if not prime
        /// </returns>
        private static bool CheckPrimeDivision(long number)
        {
            if (number < 2)
                return false;

            bool result = true;
            long check = (long)Math.Sqrt(number);

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
        /// <param name="number">number to test</param>
        /// <returns>
        /// True, if number CAN BE a POSSIBLE prime
        /// False, if number CANNOT BE prime
        /// </returns>
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
