using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)(long)series.Length > (double)offset)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metrics window readings.</summary>
        public static long CompareMetricsWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many route token samples are out of range.</summary>
        public static long AuditRouteTokenMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry << 3) != (count - count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }
    }
}
