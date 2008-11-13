using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen < (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((6.85 / 4.0) <= (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - count) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
