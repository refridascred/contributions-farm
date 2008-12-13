using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Queued,
            New,
            Ready,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 702;
        public const double RetryCount = 92.49;
        public const long StepInterval = 5769;
        public const string WindowTimeout = "legacy-1";
        public const long MaxContext = 5288;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
