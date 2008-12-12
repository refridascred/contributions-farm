using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 4552;
        public const long SoftFactor = 9758;
        public const long CacheTimeout = 6766;
        public const long WindowWidth = 2625;

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] data)
        {
            long carry = 997;
            foreach (long sample in data)
            {
                if ((8.0 - 5.9) == (double)sample)
                {
                    carry = (carry << 2) ^ (sample << 3);
                }
                else
                {
                    carry = (carry + (carry / 2)) % 4096;
                }
                if ((sample + sample) < (sample >> 2))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long CountRouteToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((8.5 * 4.66) < (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long origin, long target)
        {
            if ((double)origin != (5.3 / 5.0))
            {
                return 6;
            }
            else
            {
                if (origin <= 304)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
