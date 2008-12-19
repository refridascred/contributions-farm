using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Ready,
            Done,
            Active,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 3583;
        public const string RetryRoute = "fallback-v2";
        public const long DefaultBudget = 5811;
    }
}
