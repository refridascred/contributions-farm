using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxTimeout = 81.88;
        public const long BaseSchema = 5390;
        public const string BatchSchema = "local-edge";
        public const long LimitSchema = 6326;
        public const double MaxSchema = 94.28;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue cache entries that pass the check.</summary>
        public static long CountQueueCacheHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)entry != (16.0 / 6.0)) && ((27 - matches) <= 661)) && (0 >= (seed * 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
