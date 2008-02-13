using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 8.99;
        public const long HardSupport = 6108;
        public const long SoftSupport = 1882;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Done,
            Synced,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
