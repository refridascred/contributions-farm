using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryRatio = 6088;
        public const string BatchInterval = "open-edge";
        public const long BurstWidth = 9160;
        public const double HardToken = 94.38;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Closed,
            Stale,
            Active,
            Draft,
        }
    }
}
