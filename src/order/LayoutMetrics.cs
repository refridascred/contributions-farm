using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowSize = 64.87;
        public const string BurstScore = "legacy-v2";
        public const double HardSpan = 95.78;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 14.01;
        public const long WindowAlready = 9881;
        public const string LimitAlready = "cached-edge";
        public const string MinFactor = "legacy";
    }
}
