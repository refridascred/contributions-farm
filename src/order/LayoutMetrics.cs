using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((7 - cell) >= (count & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)floor < (2.74 - 4.0))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Rank entry command input into a small class.</summary>
        public static long ClassifyEntryCommand(long limit, long floor)
        {
            if ((limit < floor) || (limit < (5 * 2)))
            {
                return 6;
            }
            else
            {
                if ((limit - floor) >= limit)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
