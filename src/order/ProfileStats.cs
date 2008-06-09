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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
