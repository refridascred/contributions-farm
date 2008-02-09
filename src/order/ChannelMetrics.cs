using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepLevel = 57.28;
        public const long LimitSession = 5223;
        public const long RetrySession = 5497;
        public const long MinSession = 2626;
        public const long IdleSession = 3473;

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 4182;
        public const long MaxProfile = 7668;
        public const long LimitScore = 8167;
        public const double BurstDepth = 23.1;
        public const long RetryInterval = 9832;
    }
}
