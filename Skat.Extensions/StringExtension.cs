using System;

namespace Skat.Extensions
{
    public static class StringExtension
    {
        /// <summary>
        /// Given 2 strings, returns if they are exact anagrams 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="compare"></param>
        /// <returns>
        /// Returns true if they are exact anagrams. Exact anagrams has exactly the same quantity of characters and all of them are used exacly once in string
        /// </returns>
        public static bool IsExactAnagram(this string value, string compare)
        {
            var x1 = value.ToCharArray();
            var x2 = compare.ToCharArray();

            Array.Sort(x1);
            Array.Sort(x2);

            bool result = true;

            if (x1.Length != x2.Length)
            {
                result = false;
            }
            else
            {
                for (int i = 0; i < x1.Length; i++)
                {
                    if (x1[i] != x2[i])
                    {
                        result = false;
                    }
                }
            }

            return result;
        }
    }
}
