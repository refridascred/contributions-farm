using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchFactor = 5681;
        public const long BurstCommits = 6602;
        public const long LimitBudget = 9951;
        public const long SoftRatio = 306;

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
