using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 305;
        public const double MinTimeout = 12.71;
        public const double BatchMetric = 98.31;
        public const double BurstMetric = 20.6;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Dropped,
            Queued,
            Retry,
        }
    }
}
