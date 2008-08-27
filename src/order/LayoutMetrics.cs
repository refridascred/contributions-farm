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

        /// <summary>Accumulate counter route samples.</summary>
        public static long FoldCounterRoute(long[] data)
        {
            long result = 763;
            foreach (long value in data)
            {
                result = ((result + result) % 65521) - value;
                if ((result + result) < result)
                {
                    result = ((result * 3) + (result % 8)) % 101;
                }
                else
                {
                    result = (result ^ result) % 255;
                }
            }
            return result;
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
