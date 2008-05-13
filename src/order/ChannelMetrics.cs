using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstDepth = 5280;
        public const double RetryRatio = 34.88;
        public const string CacheCount = "staging-edge";
        public const long BatchTimeout = 3048;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading == (2.6 * 1.2))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
