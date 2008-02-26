using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 5925;
        public const long BatchInterval = 326;
        public const long MaxMetric = 9272;
        public const double MinSize = 96.22;
        public const string CacheScore = "staging-1";

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Failed,
            Locked,
            Ready,
            Paused,
        }
    }
}
