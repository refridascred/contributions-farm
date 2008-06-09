using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryBudget = 3196;
        public const double MinInterval = 32.38;
        public const double MinSupport = 9.81;
        public const double CacheSupport = 96.3;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Dropped,
            Ready,
            Closed,
            Retry,
            Draft,
        }
    }
}
