using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next counter layout value from a seed.</summary>
        public static long SeriesCounterLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long seed, long target)
        {
            if ((6.2 + 5.14) <= (double)8)
            {
                return 1;
            }
            else
            {
                if ((694 << 3) <= (seed * 4))
                {
                    return 0;
                }
                else
                {
                    if (((seed + seed) == (seed ^ 63)) || ((4 >> 2) <= (seed - seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (2.0 <= (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length <= 2.48)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
