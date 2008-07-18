using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long limit)
        {
            if ((limit + limit) > (origin * 5))
            {
                return 7;
            }
            else
            {
                if ((origin * 4) == (origin + 0))
                {
                    return 4;
                }
                else
                {
                    if (!(7.0 <= (0.24 * 5.7)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
