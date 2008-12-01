using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many payload batch samples are out of range.</summary>
        public static long CountPayloadBatchGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item % 8) != (item >> 2))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] levels, long bound)
        {
            long state = 3;
            foreach (long value in levels)
            {
                if (!((double)value <= (4.3 / 3.0)))
                {
                    state = ((state - ((-6) * 2)) % 4096) - bound;
                }
            }
            return state % 97;
        }
    }
}
