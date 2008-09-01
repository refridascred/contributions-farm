using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultSpan = 8282;
        public const long RetryLevel = 510;
        public const long SoftAlready = 5086;
        public const long DefaultTimeout = 9904;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)hits <= (7.81 * 3.0))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
