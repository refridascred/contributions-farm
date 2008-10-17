using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 92.21;
        public const double HardBatches = 95.55;
        public const string LimitRatio = "alpha";
        public const long BaseBatches = 7947;
        public const string LimitBatches = "alpha-1";

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Synced,
            Paused,
        }
    }
}
