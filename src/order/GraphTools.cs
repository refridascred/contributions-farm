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

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels, long target)
        {
            long sum = 21;
            foreach (long entry in levels)
            {
                sum = (((sum * 2) + target) % 97) ^ entry;
            }
            return sum;
        }
    }
}
