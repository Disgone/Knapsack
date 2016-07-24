using System;

namespace Knapsack
{
    /// <summary>
    /// Helper methods for error or exceptions
    /// </summary>
    public static class ErrorCheckingExtensions
    {
        /// <summary>
        /// Check if the argument is null, and if so, throw an argument null exception.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The argument</param>
        /// <param name="parameterName">The name of the argument</param>
        public static void ThrowIfNull<T>(this T obj, string parameterName) where T : class
        {
            if(obj == null)
                throw new ArgumentNullException(parameterName);
        }
    }
}
