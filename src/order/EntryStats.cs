using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 1561;
        public const string WindowMetric = "latest-edge";
        public const long StepMetric = 6824;
        public const long HardLevel = 6546;

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardSize = 20.66;
        public const string SoftMetric = "open-v2";
        public const string HardMetric = "local-v2";
        public const long StepBudget = 800;

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheRatio = 82.96;
        public const long DefaultFilter = 9608;
        public const double BaseCount = 23.32;
        public const string StepInterval = "staging-1";

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Idle,
            Stale,
            Locked,
        }
    }
}
