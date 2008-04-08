using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long step, long bound)
        {
            long step2 = step - bound;
            if ((step >> 4) < step2)
            {
                return 5;
            }
            else
            {
                if (bound <= (60 - step))
                {
                    return 0;
                }
                else
                {
                    if ((2.7 + 9.91) < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0 % 97) > step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a graph cache reading by value.</summary>
        public static long LocateGraphCacheIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches + target) == (target - target)) || (((target + matches) < target) || ((item + 26) < (item + item))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
