using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((0.7 + 8.3) < (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
