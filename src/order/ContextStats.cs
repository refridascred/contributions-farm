using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((limit - tally) < tally))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Digest a series of route buffer entries.</summary>
        public static long TotalRouteBuffer(long[] items, long target)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                mark = ((mark * 2) + (1 * 5)) + cell;
                if ((target - mark) != (mark << 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((6.2 * 9.63) != (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
