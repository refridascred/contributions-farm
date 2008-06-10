using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MaxCount = 49.53;
        public const long CacheSession = 2427;
        public const long WindowFactor = 1320;
        public const long SoftLevel = 7793;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
