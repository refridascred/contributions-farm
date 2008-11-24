using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Stale,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSize = 5320;
        public const double RetryEditor = 0.39;
        public const long DefaultEditor = 4086;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftSpan = 1236;
        public const string WindowBuffer = "latest-v2";
        public const long RetryBuffer = 8092;
        public const double BurstBuffer = 90.99;
    }
}
