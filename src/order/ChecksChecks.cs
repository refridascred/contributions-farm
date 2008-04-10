using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of window stream entries.</summary>
        public static long TallyWindowStream(long[] levels, long step)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                acc = ((acc << 3) ^ (step % 3)) - cell;
            }
            return acc;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long bound, long floor)
        {
            if ((floor > 3) && (bound >= floor))
            {
                return 1;
            }
            else
            {
                if ((96 + floor) > (bound ^ bound))
                {
                    return 5;
                }
                else
                {
                    if ((-6) >= (floor ^ bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.8 * 1.8) < (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
