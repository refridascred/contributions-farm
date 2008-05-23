using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Label { get; set; } = "";
            public double Level { get; set; }
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowRatio = 7744;
        public const string RetryDepth = "legacy-1";
        public const double RetryBatches = 86.54;
    }
}
