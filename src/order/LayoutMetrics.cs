using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 678;
        public const long LimitCommits = 5545;
        public const long StepRatio = 6327;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
