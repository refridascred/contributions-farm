using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 2287;
        public const long SoftWidth = 1972;
        public const double BurstToken = 97.93;
        public const long SoftToken = 6988;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count & 255) >= (count - 38))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
