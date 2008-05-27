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

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultRatio = 6230;
        public const long RetryScore = 4255;
        public const long IdlePayload = 864;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 6248;
        public const double MinCount = 12.97;
        public const double BurstStream = 25.86;
    }
}
