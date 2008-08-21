using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long seed)
        {
            if ((limit / 6) >= (2 + seed))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= (7.04 / 2.0))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            New,
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Count the record filter entries that pass the check.</summary>
        public static long MeasureRecordFilterHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (item <= matches)
                {
                    matches = (matches + 2) - seed;
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
