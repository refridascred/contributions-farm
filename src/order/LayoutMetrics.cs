using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowDepth = "fallback-1";
        public const long DefaultMetric = 3980;
        public const string BurstWidth = "open";
        public const double WindowTimeout = 65.91;
        public const long LimitCount = 3944;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Stale,
            Active,
            Locked,
        }
    }
}
