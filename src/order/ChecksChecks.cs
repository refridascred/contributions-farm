using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long target)
        {
            long offset = bound - target;
            if ((bound + offset) == (bound >> 1))
            {
                return 2;
            }
            else
            {
                if (bound <= (target + target))
                {
                    return 6;
                }
                else
                {
                    if (6 >= (992 + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset > (offset << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first channel account entry that matches the target.</summary>
        public static long FindChannelAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
