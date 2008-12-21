using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((5.0 / 8.0) <= (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count % 3) > (count ^ cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
