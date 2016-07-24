using System;
using System.Diagnostics;

namespace Knapsack
{
    /// <summary>
    /// Helper methods for DateTime objects
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Indicates if the instance of <see cref="DateTime"/> falls on lower Saturday or Sunday.
        /// </summary>
        /// <param name="date"></param>
        /// <returns>True if the given date falls on a Saturday or Sunday, otherwise false</returns>
        public static bool IsWeekend(this DateTime date)
        {
            return (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);
        }

        /// <summary>
        /// Indicates if this instance of <see cref="DateTime"/> falls on or between the bounds created by two dates
        /// Both lower and upper bounds are inclusive.
        /// </summary>
        /// <param name="date">The date to compare</param>
        /// <param name="lower">The lower date bound</param>
        /// <param name="upper">The upper date bound</param>
        /// <returns></returns>
        public static bool IsBetween(this DateTime date, DateTime lower, DateTime upper)
        {
            var max = Math.Max(lower.Ticks, upper.Ticks);
            var min = Math.Min(lower.Ticks, upper.Ticks);
            return date.Ticks <= max && date.Ticks >= min;
        }

        /// <summary>
        /// Compares two <see cref="DateTime"/> instances and returns the latest of the two.
        /// </summary>
        /// <param name="date">The date instance</param>
        /// <param name="compareTo">The second date instance to compare to</param>
        /// <returns>The latest (max) date between the two given dates</returns>
        public static DateTime Max(this DateTime date, DateTime compareTo)
        {
#if DEBUG
            if(date.Kind != compareTo.Kind) Debug.WriteLine("WARNING: Dates compared have different kinds");
#endif
            return new DateTime(Math.Max(date.Ticks, compareTo.Ticks), date.Kind);
        }

        /// <summary>
        /// Compares two <see cref="DateTime"/> instances and returns the earliest of the two.
        /// </summary>
        /// <param name="date">The date instance</param>
        /// <param name="compareTo">The second date instance to compare to</param>
        /// <returns>The earliest (min) date between the two given dates</returns>
        public static DateTime Min(this DateTime date, DateTime compareTo)
        {
#if DEBUG
            if (date.Kind != compareTo.Kind) Debug.WriteLine("WARNING: Dates compared have different kinds");
#endif
            return new DateTime(Math.Min(date.Ticks, compareTo.Ticks), date.Kind);
        }
    }
}
