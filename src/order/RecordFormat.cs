using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Pending,
            New,
            Active,
            Queued,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 35.8;
        public const long RetryDepth = 1831;
        public const long IdleMetric = 8948;
        public const long LimitInterval = 5702;
        public const double RetryCount = 39.75;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
