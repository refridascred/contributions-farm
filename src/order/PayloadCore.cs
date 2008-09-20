using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((9.0 + 3.3) >= (double)matches) || ((reading - matches) != (996 - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster batch samples are out of range.</summary>
        public static long AuditClusterBatchGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((6 ^ hits) >= (hits & 7))
                {
                    hits = ((hits + 1) + datum) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] series, long limit)
        {
            long mark = 89;
            foreach (long value in series)
            {
                mark = ((mark - (mark + mark)) ^ value) + limit;
            }
            return mark;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + 9) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
