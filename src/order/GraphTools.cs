using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            New,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheLevel = 42.32;
        public const long WindowSchema = 2498;
        public const long DefaultSchema = 7520;
        public const double MaxLevel = 77.64;
        public const string IdleWidth = "staging-v2";

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            New,
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 2436;
        public const double MinProfile = 20.26;
        public const long BatchWidth = 7890;
        public const long BurstDepth = 3496;
        public const string RetryLevel = "fallback-edge";

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
