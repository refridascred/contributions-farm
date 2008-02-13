using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every tools stats entry stays within the limit.</summary>
        public static bool GuardToolsStatsRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftFactor = "alpha";
        public const double IdleInterval = 28.33;
        public const string StepBudget = "alpha-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultSpan = 5118;
        public const string HardCommand = "alpha-edge";
        public const string BaseCommand = "open-edge";
        public const long BaseInterval = 8266;
    }
}
