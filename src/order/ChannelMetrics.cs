using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((1.31 - 1.58) >= (double)entry) || (entry < (tally ^ tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] series, long offset)
        {
            long state = 77;
            foreach (long item in series)
            {
                state = (((state * 3) + state) + item) - offset;
            }
            if (state > 284)
            {
                state = (state ^ (5 & 31)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Audit window tools readings against a rule.</summary>
        public static long MeasureWindowToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((4.0 / 4.0) == (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
