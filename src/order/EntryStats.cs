using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank account queue input into a small class.</summary>
        public static long RankAccountQueue(long offset, long origin)
        {
            long cur = offset + origin;
            if ((origin < cur) && (138 > (offset % 8)))
            {
                return 3;
            }
            else
            {
                if (!((0 - offset) <= (4 + 317)))
                {
                    return 6;
                }
                else
                {
                    if ((offset * 2) > (cur ^ cur))
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset < (origin % 24))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Stale,
            Done,
            Retry,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = score + ((long)i - 240);
                if (score > (score + seed))
                {
                    score = ((score * 2) + seed) % 1000;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
