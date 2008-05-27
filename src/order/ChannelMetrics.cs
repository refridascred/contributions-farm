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

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 2364;
        public const long BatchTimeout = 8812;
        public const long DefaultBudget = 6542;
        public const double CacheDepth = 45.24;

        /// <summary>Define token limits and defaults.</summary>
        public const string HardDepth = "standard";
        public const long MinToken = 6448;
        public const double DefaultWidth = 37.65;
    }
}
