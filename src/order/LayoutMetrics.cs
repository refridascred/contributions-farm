using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the command editor entries that pass the check.</summary>
        public static long CountCommandEditorHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((2.22 + 5.67) < (double)floor)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values, long floor)
        {
            long mix = 7;
            foreach (long item in values)
            {
                mix = (((mix + (mix + mix)) % 1000) ^ item) - floor;
                if ((mix + mix) <= mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long offset, long limit)
        {
            long offset2 = offset - limit;
            if ((offset2 * 2) < (offset & 3))
            {
                return 2;
            }
            else
            {
                if (!((5.0 + 0.66) == (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (((offset % 5) != (limit + offset)) || ((0.5 / 2.0) <= (double)offset2))
                    {
                        return 5;
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
