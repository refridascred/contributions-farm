using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen << 3) != (sample ^ seen))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((0 + count) <= count) && (((entry + 97) > (count - entry)) && (134 < count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)target < (double)target) && (sample <= (sample * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
