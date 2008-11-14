using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((9.0 + 17.0) != (double)floor) || ((floor - seen) < (0 << 2)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 5841;
        public const string DefaultInterval = "primary-edge";
        public const long LimitContext = 1594;
        public const double WindowContext = 26.93;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstCount = 2994;
        public const long HardGraph = 3913;
        public const long SoftWidth = 6696;
        public const long WindowLevel = 8810;
        public const long RetryGraph = 7219;
    }
}
