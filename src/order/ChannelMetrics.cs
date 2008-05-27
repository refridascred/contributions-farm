using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 7276;
        public const double StepScore = 9.29;
        public const double LimitReport = 17.28;
        public const long StepBudget = 9802;
        public const long HardReport = 1473;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 6791;
        public const string BatchCluster = "alpha-v2";
        public const string MaxRatio = "alpha-v2";
        public const string BaseCount = "standard-v2";

        /// <summary>Define token limits and defaults.</summary>
        public const string HardDepth = "standard";
        public const long MinToken = 6448;
        public const double DefaultWidth = 37.65;
    }
}
