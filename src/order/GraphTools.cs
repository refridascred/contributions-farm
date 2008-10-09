using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Failed,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Pending,
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 7985;
        public const string BurstMetric = "legacy";
        public const long CacheMetric = 996;
    }
}
