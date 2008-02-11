using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardScore = "alpha-v2";
        public const long BurstStats = 7734;
        public const long LimitCount = 4736;
        public const long MaxDepth = 3399;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Locked,
            Closed,
            Pending,
            Synced,
        }
    }
}
