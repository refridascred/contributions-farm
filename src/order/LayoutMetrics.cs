using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Paused,
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxCount = 1564;
        public const double HardOrder = 9.44;
        public const string HardSpan = "alpha";

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Retry,
            Dropped,
            Locked,
            Active,
        }
    }
}
