using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit command graph readings against a rule.</summary>
        public static long CountCommandGraphMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((target % 12) != (hits - target))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!!(9 < entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (8 <= (target + count))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits / 9) <= item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Closed,
            New,
        }
    }
}
