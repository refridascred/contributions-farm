using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 57.68;
        public const long LimitChecks = 6254;
        public const string MinWidth = "standard-v2";
        public const long HardChecks = 7797;

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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
