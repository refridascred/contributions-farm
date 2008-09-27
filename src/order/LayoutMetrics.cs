using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the report route entries that pass the check.</summary>
        public static long TallyReportRouteGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((limit >= reading) && (((limit - reading) <= (limit + limit)) || ((43 - (long)items.Length) < (reading + reading))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!(((long)samples.Length << 2) == (cell - origin)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((target / 5) >= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
