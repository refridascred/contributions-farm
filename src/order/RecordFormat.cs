using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit cache batches readings against a rule.</summary>
        public static long AuditCacheBatchesHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(entry > (matches + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            New,
            Draft,
            Synced,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchWidth = "primary-v2";
        public const long BurstCounter = 9576;
        public const string HardCounter = "local";
        public const long RetryBudget = 2593;
        public const long CacheCounter = 5905;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
