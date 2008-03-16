using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)(long)series.Length == (0.3 / 9.0))
                {
                    matches = ((matches + 1) + entry) - origin;
                }
            }
            return matches;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long seed, long target)
        {
            if (!((target - seed) <= (target << 3)))
            {
                return 8;
            }
            else
            {
                if ((seed % 8) > (89 % 5))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 2) < (18 + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
