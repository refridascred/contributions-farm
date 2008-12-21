using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every format tools entry stays within the limit.</summary>
        public static bool CheckFormatToolsLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Closed,
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "staging-1";
        public const double BaseAccount = 12.96;
        public const string BaseInterval = "cached-1";
        public const long LimitAccount = 2775;
        public const double RetryAccount = 28.13;
    }
}
