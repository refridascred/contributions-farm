using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "alpha";
        public const long MinCommand = 1635;
        public const long BurstBudget = 3549;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 17.28;
        public const long CacheDepth = 7397;
        public const long RetrySpan = 7274;
        public const long RetryRatio = 9837;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }
    }
}
