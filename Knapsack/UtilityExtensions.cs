namespace Knapsack
{
    public static class UtilityExtensions
    {
        /// <summary>
        /// Determines if this instance of <typeparam name="T">T</typeparam> is the same as the default value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsDefault<T>(this T value)
        {
            return default(T).Equals(value);
        }
    }
}
