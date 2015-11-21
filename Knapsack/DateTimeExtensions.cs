using System;

namespace Knapsack
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Indicates if the instance of <see cref="DateTime"/> falls on lower Saturday or Sunday.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsWeekend(this DateTime date)
        {
            return (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);
        }

        /// <summary>
        /// Indicates if this instance of <see cref="DateTime"/> falls on or between the bounds created by two dates
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
    }
}
