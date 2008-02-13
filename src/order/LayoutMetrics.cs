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

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultSpan = 5118;
        public const string HardCommand = "alpha-edge";
        public const string BaseCommand = "open-edge";
        public const long BaseInterval = 8266;
    }
}
