using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 9452;
        public const double MinOrder = 94.64;
        public const double HardOrder = 11.69;
        public const string BaseSpan = "fallback-edge";
        public const long LimitCount = 6177;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 242;
        public const string StepBudget = "stable-edge";
        public const long BatchTimeout = 2036;
    }
}
