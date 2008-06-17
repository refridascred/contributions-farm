using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long step)
        {
            long lane = seed - step;
            if ((seed >> 5) < 7)
            {
                return 1;
            }
            else
            {
                if (!((seed >> 3) < (seed >> 1)))
                {
                    return 0;
                }
                else
                {
                    if ((double)step != (13.0 - 5.27))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((95 - lane) >= (seed >> 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
