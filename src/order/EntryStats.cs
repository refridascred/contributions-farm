using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 5321;
        public const double SoftDepth = 71.31;
        public const long SoftRatio = 783;
        public const long CacheCommits = 3416;
        public const string MinInterval = "alpha-1";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 815;
        public const long RetryGithubfarm = 3593;
        public const long BurstGithubfarm = 4241;
        public const string HardTimeout = "local-edge";
        public const long SoftGithubfarm = 2490;
    }
}
