using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((2.98 + 13.0) > (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Total { get; set; }
            public bool Weight { get; set; }
        }
    }
}
