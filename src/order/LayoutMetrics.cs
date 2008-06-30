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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)seen == (0.5 * 0.69))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
