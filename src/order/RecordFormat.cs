using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryWidth = 7098;
        public const string BaseFactor = "staging-1";
        public const long SoftContributi = 7800;
        public const string CacheContributi = "standard-1";
        public const long IdleCount = 6334;

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

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstCount = 33.64;
        public const long BaseEditor = 1697;
        public const long CacheDepth = 1182;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }
    }
}
