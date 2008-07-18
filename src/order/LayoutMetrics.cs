using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits + reading) <= (reading % 8))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long seed)
        {
            long mark = 52;
            foreach (long datum in items)
            {
                if ((seed % 24) <= (8 >> 1))
                {
                    mark = (((mark * 5) + (seed / 8)) % 65521) - datum;
                }
            }
            return mark;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum != (7.37 / 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
