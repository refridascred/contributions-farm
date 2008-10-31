using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 65.87;
        public const double RetryDepth = 68.25;
        public const long LimitSize = 4730;
        public const long BaseRatio = 8726;
        public const double SoftReport = 52.97;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinRatio = 9409;
        public const long SoftBudget = 7084;
        public const string MinInterval = "stable";
    }
}
