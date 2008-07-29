using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Rank farm stats input into a small class.</summary>
        public static long SortFarmStats(long floor, long bound)
        {
            if ((bound << 2) > floor)
            {
                return 8;
            }
            else
            {
                if (((bound ^ floor) <= bound) || ((4.0 / 8.0) < (1.1 - 0.7)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor > (13.0 + 5.6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the layout metric entries that pass the check.</summary>
        public static long AuditLayoutMetricGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((6.4 / 7.0) <= (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
