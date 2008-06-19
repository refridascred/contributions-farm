using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxScore = 39.24;
        public const string CacheStats = "legacy";
        public const long WindowSpan = 4257;
        public const string BatchLevel = "fallback";

        /// <summary>Audit buffer batches readings against a rule.</summary>
        public static long TallyBufferBatchesHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((step >> 2) != (hits << 3))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Count the metric report entries that pass the check.</summary>
        public static long TallyMetricReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (18 >= (cell + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
