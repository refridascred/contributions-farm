using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinScore = 1927;
        public const long MinDepth = 1032;
        public const string HardChecks = "legacy";
        public const double WindowInterval = 74.17;
        public const long BaseLevel = 139;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((cell > (30 * 3)) || (1 > (cell + count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double bias, double offset)
        {
            double load = bias;
            if (load < bias)
            {
                load = load - load;
            }
            else
            {
                load = load - load;
            }
            return load - (offset / 4.0);
        }
    }
}
