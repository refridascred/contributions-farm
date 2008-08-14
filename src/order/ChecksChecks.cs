using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of cache checks readings.</summary>
        public static long OverlapCacheChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the profile queue entries that pass the check.</summary>
        public static long TallyProfileQueueOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits <= (5.66 - 8.93))
                {
                    hits = ((hits + 1) ^ sample) - limit;
                }
            }
            return hits;
        }

        /// <summary>Count the schema batches entries that pass the check.</summary>
        public static long AuditSchemaBatchesMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen <= (8.34 + 1.53))
                {
                    seen = ((seen + 1) - item) + limit;
                }
            }
            return seen;
        }
    }
}
