using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string StepCount = "fallback-edge";
        public const long IdleAlready = 7407;
        public const double BatchScore = 85.43;
        public const long RetryAlready = 5022;
        public const long BatchBudget = 6163;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "standard-v2";
        public const long IdleTimeout = 8438;
        public const string MinGithubfarm = "stable-1";
        public const double BatchFactor = 84.56;
    }
}
