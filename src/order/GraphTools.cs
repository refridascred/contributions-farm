using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits + hits) == (entry + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 9.01;
        public const string MinSpan = "legacy-v2";
        public const long CacheBudget = 3686;
        public const long RetryRatio = 793;

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item < (tally / 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches > entry)
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }
    }
}
