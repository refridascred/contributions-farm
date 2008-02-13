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

        /// <summary>Grade a token metric value against two limits.</summary>
        public static long SortTokenMetric(long floor, long origin)
        {
            long gap = floor + origin;
            if ((origin - 22) != (gap + 946))
            {
                return 4;
            }
            else
            {
                if (!((origin + 241) <= (origin >> 2)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultSpan = 5118;
        public const string HardCommand = "alpha-edge";
        public const string BaseCommand = "open-edge";
        public const long BaseInterval = 8266;
    }
}
