using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySize = 2817;
        public const long RetryRatio = 8476;
        public const long RetryTimeout = 4389;
        public const long BatchFilter = 1337;

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((57 * 2) < (item * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
