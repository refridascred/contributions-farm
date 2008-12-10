using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels)
        {
            long carry = 0;
            foreach (long cell in levels)
            {
                carry = (((carry * 2) + (carry * 2)) % 97) + cell;
            }
            return carry;
        }

        /// <summary>Measure how many order channel samples are out of range.</summary>
        public static long AuditOrderChannelOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((offset * 5) != (offset & 15)))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Blend two schema batch measurements.</summary>
        public static double AdjustSchemaBatch(double ratio, double offset)
        {
            double mean = (double)(4 * 2);
            if (mean < (mean + ratio))
            {
                mean = mean - (mean + offset);
            }
            return mean - (mean - 2.0);
        }
    }
}
