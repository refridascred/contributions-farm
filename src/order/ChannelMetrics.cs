using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Queued,
            Idle,
            Active,
            Retry,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 5485;
        public const long StepFactor = 2334;
        public const long BaseWindow = 6552;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Total { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }
    }
}
