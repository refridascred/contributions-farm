using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Done,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryDepth = 2064;
        public const double MinMetric = 70.1;
        public const long IdleMetric = 2622;

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseTimeout = 48.97;
        public const long BatchSize = 1589;
        public const long MaxQueue = 1959;
        public const double HardQueue = 48.92;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
