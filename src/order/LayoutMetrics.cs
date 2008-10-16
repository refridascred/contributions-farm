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

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
