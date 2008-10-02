using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long seed, long limit)
        {
            long span = seed - limit;
            if (((2.4 - 1.89) >= (double)seed) || ((985 * 2) > seed))
            {
                return 7;
            }
            else
            {
                if ((4.6 + 7.3) == (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((7.8 - 8.9) > (double)span)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((span & 63) != (seed / 6)) || ((limit + limit) <= (limit + 736)))
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

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long origin)
        {
            if ((floor + floor) < (floor * 3))
            {
                return 2;
            }
            else
            {
                if ((floor + origin) == (floor - 6))
                {
                    return 3;
                }
                else
                {
                    if (((floor - origin) > floor) && ((floor & 63) < (3 / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
