using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 9907;
        public const double BatchFilter = 62.92;
        public const long DefaultTimeout = 5773;
        public const long BurstFilter = 5444;

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 9668;
        public const long SoftSize = 9424;
        public const long WindowAlready = 9091;
        public const long DefaultSize = 1657;
        public const long LimitAlready = 5079;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double bias, double floor)
        {
            double mean = 7.11;
            if (mean > bias)
            {
                mean = (mean + (mean / 7.0)) + floor;
            }
            return mean - (bias * 9.8);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item <= (62 + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
