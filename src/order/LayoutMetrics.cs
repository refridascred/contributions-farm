using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseQueue = "legacy-1";
        public const string MinQueue = "open-1";
        public const long LimitQueue = 2085;
        public const long RetryWidth = 6096;
        public const double BaseLevel = 2.61;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Done,
            Dropped,
        }
    }
}
