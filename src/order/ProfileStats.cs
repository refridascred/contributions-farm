using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long target, long bound)
        {
            long step = target + bound;
            if ((bound - bound) <= step)
            {
                return 4;
            }
            else
            {
                if ((-4) < bound)
                {
                    return 7;
                }
                else
                {
                    if (bound <= (step * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the already stream series from a seed.</summary>
        public static long SeriesAlreadyStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of route metric readings.</summary>
        public static long FoldRouteMetric(long[] levels)
        {
            long mark = 578;
            foreach (long value in levels)
            {
                mark = ((mark << 2) ^ (value >> 3)) % 101;
            }
            if (mark > 518)
            {
                mark = (mark + (mark * 5)) % 101;
            }
            return mark;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell < (matches << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
