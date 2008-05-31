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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((matches * 2) < (cell + (-65))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
