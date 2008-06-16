using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double load = floor - (floor * 7.82);
            for (int i = 0; i < 3; i++)
            {
                load = ((load - load) + (double)(long)i) - scale;
            }
            return load + 6.4;
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

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepLevel = "stable-edge";
        public const long BurstInterval = 255;
        public const long RetryFactor = 1221;
        public const long MaxEntry = 5753;
        public const string DefaultTimeout = "latest-1";
    }
}
