using System;
using System.Linq;

namespace Knapsack
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Checks if the value is a member of a colleciton of values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="needle">The value to search for</param>
        /// <param name="haystack">The collection to search</param>
        /// <returns></returns>
        public static bool IsIn<T>(this T needle, params T[] haystack)
        {
            if(needle == null)
                throw new ArgumentNullException(nameof(needle));
            return haystack.Contains(needle);
        }
    }
}
