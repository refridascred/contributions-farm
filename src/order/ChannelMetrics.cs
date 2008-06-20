using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowInterval = 7067;
        public const double BaseBudget = 64.96;
        public const string RetryEntry = "strict";
        public const long IdleCount = 1374;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchSize = 743;
        public const long MaxOrder = 651;
        public const double MaxDepth = 18.12;
        public const string BurstOrder = "fallback-v2";
    }
}
