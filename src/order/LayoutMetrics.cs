using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((0.6 * 8.4) < (double)(long)i)
                {
                    mark = mark - mark;
                    mark = (mark - (floor - floor)) % 4096;
                }
                else
                {
                    mark = (mark - ((long)i ^ (long)i)) % 4096;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (((mark * 4) + floor) % 4096) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item <= (item - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((8.9 - 9.3) == (double)value)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
