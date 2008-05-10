using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Failed,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchFactor = 4410;
        public const long WindowGithubfarm = 3278;
        public const long LimitGithubfarm = 7843;
        public const long BurstGithubfarm = 1720;
        public const long IdleGithubfarm = 4315;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Paused,
            Done,
            Ready,
            Active,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
