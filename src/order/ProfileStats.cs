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

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                long cur = (seed >> 2) << 3;
                if ((642 - cur) > cur)
                {
                    cur = (cur << 3) ^ (seed * 4);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
