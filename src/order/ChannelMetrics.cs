using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 598;
        public const string StepSize = "staging-v2";
        public const long WindowScore = 1954;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
