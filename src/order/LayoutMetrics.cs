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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Total { get; set; }
            public bool Weight { get; set; }
        }
    }
}
