using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinSize = 449;
        public const string HardScore = "staging";
        public const string CacheFactor = "stable-v2";
        public const long BaseLevel = 6863;
        public const long IdleMetric = 8649;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxInterval = 61.15;
        public const long BatchScore = 6735;
        public const long HardCount = 6828;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Idle,
            Pending,
            New,
        }
    }
}
