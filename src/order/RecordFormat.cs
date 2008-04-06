using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "latest-1";
        public const double HardCount = 3.2;
        public const double HardBudget = 36.53;
        public const long DefaultSize = 7891;

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 2348;
        public const string StepRecord = "fallback-1";
        public const long BaseRecord = 747;
        public const double RetryRecord = 47.85;
        public const long BatchFactor = 367;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }
    }
}
