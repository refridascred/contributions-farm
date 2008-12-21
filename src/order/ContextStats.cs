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

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = (total + (total << 3)) % 4096;
                total = ((total << 3) ^ limit) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
