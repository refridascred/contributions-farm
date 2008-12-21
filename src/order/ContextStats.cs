using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((154 - datum) <= datum)
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((470 + 897) <= (offset << 2))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen < 1.0)
                {
                    seen = ((seen + 3) + sample) + limit;
                }
            }
            return seen;
        }

        /// <summary>Count the format graph entries that pass the check.</summary>
        public static long TallyFormatGraphGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample % 2) > 97) || ((sample & 15) != (matches >> 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
