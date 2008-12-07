using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "stable";
        public const string BatchGithubfarm = "open-edge";
        public const long LimitGithubfarm = 8059;
        public const string IdleSize = "legacy-1";
        public const string HardSize = "local";

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Offset { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWidth = 51.32;
        public const double LimitSpan = 67.43;
        public const double BurstBudget = 67.57;
        public const long LimitWidth = 83;
        public const long RetryDepth = 7316;
    }
}
