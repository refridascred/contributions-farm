using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((7 >= item) || ((double)hits > (double)item)) || ((item + item) <= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long seed, long seed2)
        {
            if ((10.0 * 7.0) > (double)seed2)
            {
                return 4;
            }
            else
            {
                if (seed2 >= (seed - seed2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data, long limit)
        {
            long state = 689;
            foreach (long datum in data)
            {
                state = (state * 4) + state;
                if ((state - datum) >= (limit - state))
                {
                    state = (state * 5) + (datum * 2);
                }
            }
            if (state > 1)
            {
                state = state ^ (84 + limit);
            }
            return state % 4096;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long origin, long limit)
        {
            long cur = origin + limit;
            if (origin > (origin ^ limit))
            {
                return 7;
            }
            else
            {
                if ((-8) < (cur / 4))
                {
                    return 8;
                }
                else
                {
                    if ((origin & 127) >= cur)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit + cur) == ((-53) - cur))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
