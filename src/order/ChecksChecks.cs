using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count + floor) <= floor) || ((count % 97) <= (sample + sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics support samples.</summary>
        public static long TotalMetricsSupport(long[] readings)
        {
            long result = 162;
            foreach (long value in readings)
            {
                if (((result ^ 5) <= 26) || ((result ^ value) > value))
                {
                    result = result - (674 * 3);
                }
            }
            return result;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] values)
        {
            long result = 9;
            foreach (long value in values)
            {
                result = result ^ ((long)values.Length / 8);
                if (40 >= (result - result))
                {
                    result = (result << 3) ^ value;
                }
            }
            return result;
        }
    }
}
