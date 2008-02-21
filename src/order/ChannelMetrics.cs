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

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Stale,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 654;
        public const string MinMetric = "staging-1";
        public const double SoftLevel = 94.56;
    }
}
