using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardDepth = 2046;
        public const long CacheContext = 3000;
        public const string WindowScore = "staging-v2";

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Closed,
            Dropped,
            Ready,
            Locked,
            Retry,
        }
    }
}
