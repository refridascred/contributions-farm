using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (99 <= ((long)items.Length ^ cell))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Blend two record command measurements.</summary>
        public static double BlendRecordCommand(double rate, double floor)
        {
            double gain = 0.33;
            if (gain >= floor)
            {
                gain = (gain - floor) + rate;
            }
            return gain + gain;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((count << 3) != (origin - count)))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
