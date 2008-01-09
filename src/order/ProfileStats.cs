using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryFactor = 22.53;
        public const long MaxMetric = 3391;
        public const long LimitMetric = 5894;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 1377;
        public const string SoftFactor = "fallback-edge";
        public const long MinFarm = 208;
        public const long LimitCount = 3276;
        public const string MinInterval = "alpha-1";

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            Active,
            Closed,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Dropped,
            Stale,
        }
    }
}
