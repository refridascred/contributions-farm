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

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < (rate + span))
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + span;
        }
    }
}
