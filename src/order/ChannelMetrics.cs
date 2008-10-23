using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 1613;
        public const long BatchScore = 7011;
        public const double SoftInterval = 6.44;
        public const double WindowCommits = 26.14;
        public const string DefaultCommits = "strict";

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Closed,
            Draft,
            Synced,
            Locked,
        }
    }
}
