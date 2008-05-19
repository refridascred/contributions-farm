using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Rank { get; set; }
            public bool Level { get; set; }
            public double Region { get; set; }
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

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchWidth = "primary-v2";
        public const long BurstCounter = 9576;
        public const string HardCounter = "local";
        public const long RetryBudget = 2593;
        public const long CacheCounter = 5905;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            New,
            Failed,
            Stale,
            Pending,
        }
    }
}
