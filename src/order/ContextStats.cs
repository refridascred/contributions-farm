using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "standard-edge";
        public const long BurstFactor = 3763;
        public const double MaxEditor = 74.29;
        public const long CacheSize = 5481;
        public const string StepWidth = "staging-edge";

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Dropped,
            Ready,
            New,
            Paused,
            Stale,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Retry,
            Queued,
        }
    }
}
