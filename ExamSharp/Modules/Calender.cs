using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSharp.Modules
{
    public static class Calender
    {
        /// <summary>
        /// Get Today Class
        /// </summary>
        public static class GetToday
        {
            /// <summary>
            /// Gets today as DateTime
            /// </summary>
            /// <returns>DateTime</returns>
            public static DateTime InDateTime()
            {
                return DateTime.Today;
            }

            /// <summary>
            /// Gets Today as string
            /// </summary>
            /// <returns>String</returns>
            public static string InString()
            {
                return DateTime.Today.ToString();
            }
        }

        /// <summary>
        /// Get Today Date Class
        /// </summary>
        public static class GetTodayDate
        {
            /// <summary>
            /// Gets Today's Day as int
            /// </summary>
            /// <returns>Int</returns>
            public static int InDateTime()
            {
                return DateTime.Today.Day;
            }

            /// <summary>
            /// Gets Today's Day as string
            /// </summary>
            /// <returns>String</returns>
            public static string InString()
            {
                return DateTime.Today.Day.ToString();
            }
        }

        /// <summary>
        /// Get This Month Class
        /// </summary>
        public static class GetThisMonth
        {
            /// <summary>
            /// Gets Month of Today as int
            /// </summary>
            /// <returns>Int</returns>
            public static int InDateTime()
            {
                return DateTime.Today.Month;
            }

            /// <summary>
            /// Gets Month of Today as string
            /// </summary>
            /// <returns>String</returns>
            public static string InString()
            {
                return DateTime.Today.Month.ToString();
            }
        }

        /// <summary>
        /// Get This Year Class
        /// </summary>
        public static class GetThisYear
        {
            /// <summary>
            /// Gets Year of Today as int
            /// </summary>
            /// <returns>Int</returns>
            public static int InDateTime()
            {
                return DateTime.Today.Year;
            }

            /// <summary>
            /// Gets Year of Today as string
            /// </summary>
            /// <returns>String</returns>
            public static string InString()
            {
                return DateTime.Today.Year.ToString();
            }
        }
    }
}
