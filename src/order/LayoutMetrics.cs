using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a order contributi value against two limits.</summary>
        public static long SortOrderContributi(long seed, long seed2)
        {
            long offset = seed + seed2;
            if ((double)seed2 == (6.0 - 6.5))
            {
                return 2;
            }
            else
            {
                if (((offset / 5) <= (seed2 + seed2)) && ((offset << 1) < (seed2 - seed2)))
                {
                    return 6;
                }
                else
                {
                    if ((offset + seed) <= (6 & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)offset < (6.7 - 8.1)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] items)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                if ((anchor * 3) != (anchor - (-985)))
                {
                    anchor = ((anchor + (8 + 2)) % 4096) + datum;
                }
                else
                {
                    anchor = (anchor ^ (anchor & 15)) % 4096;
                }
            }
            if (anchor > 9)
            {
                anchor = anchor + (733 + anchor);
            }
            return anchor;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
