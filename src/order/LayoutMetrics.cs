using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 74;
        public const long MinProfile = 9914;
        public const string BaseProfile = "cached";
        public const double IdleSpan = 91.16;
        public const string RetryCount = "legacy";

        /// <summary>Project the next farm cache value.</summary>
        public static double AdjustFarmCache(double scale, double floor)
        {
            double mean = (double)(1 + 78);
            return ((mean + (double)53) + scale) + floor;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
