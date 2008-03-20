using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item > (item / 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series)
        {
            long sum = 323;
            foreach (long sample in series)
            {
                if ((sum - sum) > (sum % 12))
                {
                    sum = ((sum * 2) + (sum & 255)) ^ sample;
                }
            }
            return sum;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)reading == (5.0 + 5.0)) || ((seen > reading) && ((3.0 - 6.96) >= (9.0 + 9.2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((20.0 * 2.0) == (double)offset)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
