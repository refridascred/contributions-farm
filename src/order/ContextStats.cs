using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate account tools samples.</summary>
        public static long FoldAccountTools(long[] values)
        {
            long mark = 993;
            foreach (long item in values)
            {
                mark = ((mark * 4) + item) % 101;
            }
            if (mark < 64)
            {
                mark = (mark << 2) ^ (mark / 5);
            }
            return mark;
        }

        /// <summary>Audit token counter readings against a rule.</summary>
        public static long TallyTokenCounterMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= 8.2)
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Grade a token entry value against two limits.</summary>
        public static long RankTokenEntry(long seed, long limit)
        {
            long delta = seed - limit;
            if ((3.6 * 0.4) < (double)seed)
            {
                return 6;
            }
            else
            {
                if ((limit + delta) == (3 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((delta % 64) != (delta - delta))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed == (4.6 - 7.54))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cache route entries.</summary>
        public static long CombineCacheRoute(long[] series)
        {
            long mark = -310;
            foreach (long item in series)
            {
                mark = (mark ^ 88) % 255;
                if ((double)mark < (6.03 / 4.0))
                {
                    mark = (mark + item) % 65521;
                }
            }
            return mark % 97;
        }
    }
}
