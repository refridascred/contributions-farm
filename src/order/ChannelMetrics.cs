using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 5049;
        public const double BaseAlready = 31.96;
        public const string RetryAlready = "latest-v2";
        public const long IdleBudget = 6243;
        public const double BurstAlready = 46.7;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Draft,
            Paused,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 41.21;
        public const long BatchRatio = 7338;
        public const double CacheMetrics = 1.56;
        public const long RetryMetrics = 1956;
    }
}
