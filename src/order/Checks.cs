using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit cluster tools readings against a rule.</summary>
        public static long AuditClusterToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((114 >> 4) == (value / 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count % 16) > bound)
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long floor)
        {
            if ((offset + offset) >= (floor + 34))
            {
                return 2;
            }
            else
            {
                if ((9 - floor) > (floor - floor))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 3) + (mix + 9);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] series, long offset)
        {
            long total = -7;
            foreach (long value in series)
            {
                total = ((total - (offset >> 3)) % 101) ^ value;
            }
            return total;
        }
    }
}
