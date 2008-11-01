using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((count << 1) <= item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account report entries.</summary>
        public static long TotalAccountReport(long[] samples)
        {
            long mix = 388;
            foreach (long datum in samples)
            {
                if ((mix + mix) <= mix)
                {
                    mix = (mix ^ mix) + datum;
                }
            }
            return mix;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long seed, long seed2)
        {
            long delta = seed ^ seed2;
            if ((seed - 94) == (seed - delta))
            {
                return 8;
            }
            else
            {
                if ((seed2 * 4) > (64 ^ seed))
                {
                    return 0;
                }
                else
                {
                    if ((473 + seed) > (5 % 8))
                    {
                        return 6;
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
