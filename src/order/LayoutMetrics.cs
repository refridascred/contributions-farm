using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((1.61 / 3.0) < (20.0 * 0.6))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double offset)
        {
            double bias = rate;
            return (bias - (double)6) + offset;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 2626;
        public const long CacheRatio = 8986;
        public const string BaseMetric = "staging-edge";
    }
}
