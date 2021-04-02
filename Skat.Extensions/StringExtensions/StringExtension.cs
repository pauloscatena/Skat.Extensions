using System;

namespace Skat.Extensions.StringExtensions
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
            var x1 = value.RemoveSpacesAndPunctuation().ToCharArray();
            var x2 = compare.RemoveSpacesAndPunctuation().ToCharArray();

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

        /// <summary>
        /// Removes all characters except number and letters
        /// </summary>
        /// <param name="value">string to test</param>
        /// <returns>
        /// String containing only numbers and letters
        /// </returns>
        public static string RemoveSpacesAndPunctuation(this string value)
        {
            string result = string.Empty;

            foreach(char c in value)
            {
                var ascii = (int)c;
                if ((ascii >= 48 && ascii <= 57) ||
                    (ascii >= 65 && ascii <= 90) ||
                    (ascii >= 97 && ascii <= 122))
                    result += c;
            }

            return result;
        }

        public static bool IsPalindrome(this string value)
        {
            value = value.RemoveSpacesAndPunctuation().ToLower();
            bool result = true;
            for(int i = 0; i < value.Length; i++)
            {
                if (value[i] != value[(value.Length - 1) - i])
                {
                    result = false;
                }

            }
            return result;
        }
    }
}
