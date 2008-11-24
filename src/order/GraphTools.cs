using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string WindowWidth = "fallback-v2";
        public const string DefaultRoute = "open-1";
        public const double CacheRoute = 85.71;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Failed,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSpan = 5960;
        public const double BatchWidth = 26.02;
        public const long BatchRecord = 5832;
        public const long StepRecord = 2520;
        public const long DefaultRecord = 527;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Count { get; set; }
            public double Score { get; set; }
        }
    }
}
