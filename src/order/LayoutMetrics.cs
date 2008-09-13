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
        public const long BurstLevel = 3364;
        public const double IdleCount = 86.19;
        public const long IdleMetric = 51;

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
