using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Stale,
            Retry,
            Idle,
            Ready,
            Active,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Draft,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
