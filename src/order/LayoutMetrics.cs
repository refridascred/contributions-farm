using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((cell * 3) == (cell ^ cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleInterval = 7498;
        public const string SoftDepth = "alpha";
        public const double HardChecks = 35.26;
        public const double BurstChecks = 90.36;
        public const long RetryTimeout = 7029;

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double rate = (ratio + ratio) - ratio;
            if (rate > (double)7)
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
