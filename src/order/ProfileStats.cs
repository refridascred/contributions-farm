using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a stats route sample.</summary>
        public static long LookupStatsRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitDepth = 17.55;
        public const long DefaultRatio = 9572;
        public const double LimitBatch = 50.43;
        public const double MinBatch = 42.85;
        public const string WindowBatch = "legacy-1";

        /// <summary>Count cache entry pairs that satisfy a relation.</summary>
        public static long MatchCacheEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((5.4 * 6.4) >= (double)matches)
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
