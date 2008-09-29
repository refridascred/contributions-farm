using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 8418;
        public const long IdleMetric = 8177;
        public const long CacheMetric = 3297;
        public const long LimitMetric = 6895;
        public const string MinMetric = "latest-1";

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
