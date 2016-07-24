using System;

namespace Knapsack
{
    /// <summary>
    /// Helper methods for string objects
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Compares two strings for equality without case sensitivity using the current culture.
        /// </summary>
        /// <param name="myValue">The current value</param>
        /// <param name="comparison">The string to compare against</param>
        /// <returns></returns>
        public static bool Matches(this string myValue, string comparison)
        {
            return string.Equals(myValue, comparison, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
