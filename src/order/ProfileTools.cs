using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long offset)
        {
            if (((double)origin != (7.4 * 8.0)) || (offset <= (5 + origin)))
            {
                return 4;
            }
            else
            {
                if (origin < (origin & 1))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long origin, long limit)
        {
            if ((limit / 8) != (origin << 2))
            {
                return 7;
            }
            else
            {
                if (((limit << 2) != (origin & 63)) || ((origin * 5) >= (limit >> 3)))
                {
                    return 0;
                }
                else
                {
                    if ((origin - 507) > (limit << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((9 + limit) > origin) && ((1.5 + 9.8) != (double)limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
