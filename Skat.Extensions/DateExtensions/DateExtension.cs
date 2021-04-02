using System;

namespace Skat.Extensions.DateExtensions
{
    public static class DateExtension
    {
        // Constants
        private static int __CARNIVAL_DAYS_BEFORE_EASTER = -47;
        private static int __CORPUS_CHRISTI_DAYS_AFTER_EASTER = 60;

        /// <summary>
        /// Returns Easter date of that year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static DateTime GetEaster(int year)
        {
            int nRest = (year % 19) + 1;
            DateTime result = new DateTime();
            switch (nRest)
            {
                case 1: result = new System.DateTime(year, 4, 14, 0, 0, 0, 0); break;
                case 2: result = new System.DateTime(year, 4, 3, 0, 0, 0, 0); break;
                case 3: result = new System.DateTime(year, 3, 23, 0, 0, 0, 0); break;
                case 4: result = new System.DateTime(year, 4, 11, 0, 0, 0, 0); break;
                case 5: result = new System.DateTime(year, 3, 31, 0, 0, 0, 0); break;
                case 6: result = new System.DateTime(year, 4, 18, 0, 0, 0, 0); break;
                case 7: result = new System.DateTime(year, 4, 8, 0, 0, 0, 0); break;
                case 8: result = new System.DateTime(year, 3, 28, 0, 0, 0, 0); break;
                case 9: result = new System.DateTime(year, 4, 16, 0, 0, 0, 0); break;
                case 10: result = new System.DateTime(year, 4, 5, 0, 0, 0, 0); break;
                case 11: result = new System.DateTime(year, 3, 25, 0, 0, 0, 0); break;
                case 12: result = new System.DateTime(year, 4, 13, 0, 0, 0, 0); break;
                case 13: result = new System.DateTime(year, 4, 2, 0, 0, 0, 0); break;
                case 14: result = new System.DateTime(year, 3, 22, 0, 0, 0, 0); break;
                case 15: result = new System.DateTime(year, 4, 10, 0, 0, 0, 0); break;
                case 16: result = new System.DateTime(year, 3, 30, 0, 0, 0, 0); break;
                case 17: result = new System.DateTime(year, 4, 17, 0, 0, 0, 0); break;
                case 18: result = new System.DateTime(year, 4, 7, 0, 0, 0, 0); break;
                case 19: result = new System.DateTime(year, 3, 27, 0, 0, 0, 0); break;
            }
            for (int n = 1; n <= 13; n++)
            {
                result = result.AddDays(1);
                if (result.DayOfWeek == DayOfWeek.Sunday)
                {
                    return result;
                }
            }

            return new DateTime();
        }

        /// <summary>
        /// Returns Brazilian Carnival Tuesday date
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static DateTime GetBrazilianCarnival(int year)
        {
            return GetEaster(year).AddDays(__CARNIVAL_DAYS_BEFORE_EASTER);
        }

        /// <summary>
        /// Returns Body of God date
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static DateTime GetCorpusChristi(int year)
        {
            return GetEaster(year).AddDays(__CORPUS_CHRISTI_DAYS_AFTER_EASTER);
        }

        /// <summary>
        /// Returns Good Friday date
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static DateTime GetGoodFriday(int year)
        {
            return GetEaster(year).AddDays(-2);
        }

        /// <summary>
        /// Returns Easter Monday date (for Polish's holiday)
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static DateTime GetEasterMonday(int year)
        {
            return GetEaster(year).AddDays(1);
        }
    }
}
