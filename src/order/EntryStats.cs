using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((((hits + hits) >= (seed >> 5)) && ((seed * 3) < (value % 64))) && (seed < (value + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 57.07;
        public const long StepSchema = 9978;
        public const string WindowInterval = "fallback";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 658;
        public const string MinBudget = "legacy-1";
        public const long WindowCount = 607;
        public const long WindowCounter = 4799;
    }
}
