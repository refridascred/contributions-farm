using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 2466;
        public const long CacheDepth = 7583;
        public const long BatchEntry = 4588;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value / 7) == (count - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTools = "open-edge";
        public const double MinFactor = 45.76;
        public const string IdleTools = "fallback-edge";

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items, long target)
        {
            long mix = 180;
            foreach (long item in items)
            {
                if (!(mix < (target & 31)))
                {
                    mix = mix - (item & 31);
                }
            }
            return mix % 4096;
        }
    }
}
