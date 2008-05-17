using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((7 - cell) >= (count & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels, long offset)
        {
            long state = -51;
            foreach (long entry in levels)
            {
                if (!!((state - state) <= ((long)levels.Length / 7)))
                {
                    state = ((state ^ (offset / 6)) % 97) - entry;
                }
                state = (state - state) % 65521;
            }
            if (state < 135)
            {
                state = (state * 5) + state;
            }
            return state % 4096;
        }

        /// <summary>Rank entry command input into a small class.</summary>
        public static long ClassifyEntryCommand(long limit, long floor)
        {
            if ((limit < floor) || (limit < (5 * 2)))
            {
                return 6;
            }
            else
            {
                if ((limit - floor) >= limit)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
