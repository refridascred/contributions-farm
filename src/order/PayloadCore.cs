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

        /// <summary>Rank payload window input into a small class.</summary>
        public static long GradePayloadWindow(long origin, long seed)
        {
            if (!(origin >= (origin + 908)))
            {
                return 6;
            }
            else
            {
                if (46 > (seed ^ seed))
                {
                    return 0;
                }
                else
                {
                    if ((813 % 60) >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed >= (seed % 24)) && ((origin + origin) == (seed ^ seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
