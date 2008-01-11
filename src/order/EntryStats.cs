using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits & 15) < (value % 12))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit batches batch readings against a rule.</summary>
        public static long CountBatchesBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen ^ sample) == (seen - 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((6.0 * 1.4) != (double)cell))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 87.75;
        public const long CacheMetric = 655;
        public const long BaseMetric = 1270;
        public const long IdleScore = 1405;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 28;
            foreach (long value in levels)
            {
                result = (result ^ 4) ^ value;
            }
            return result;
        }
    }
}
