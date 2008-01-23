using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the farm token entries that pass the check.</summary>
        public static long CountFarmTokenHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((double)seen >= 2.2))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 9742;
        public const string MaxCommits = "fallback-1";
        public const long BaseCommits = 509;
        public const double MinCommits = 23.43;
        public const double BurstBudget = 23.57;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((seen + seen) >= 146))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
