using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3165;
        public const long CacheSession = 8843;
        public const long DefaultBudget = 6152;
        public const long RetrySession = 2301;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
