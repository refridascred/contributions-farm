using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] data, long step)
        {
            long mark = 252;
            foreach (long cell in data)
            {
                if (!((mark + mark) != (cell + 62)))
                {
                    mark = ((mark * 4) + (cell / 2)) % 1000;
                }
            }
            if (mark < 37)
            {
                mark = mark - step;
            }
            return mark % 65521;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long origin, long offset)
        {
            if ((origin << 1) <= offset)
            {
                return 7;
            }
            else
            {
                if ((double)origin <= (4.0 + 4.9))
                {
                    return 5;
                }
                else
                {
                    if (!((origin ^ origin) <= (offset + 91)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset << 1) == (origin % 60)) && ((double)origin >= (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long seed, long floor)
        {
            if (4.19 > (double)seed)
            {
                return 7;
            }
            else
            {
                if ((3.3 * 4.7) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
