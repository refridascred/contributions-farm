using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long offset)
        {
            long anchor = 3;
            foreach (long reading in data)
            {
                anchor = (((anchor << 3) ^ (808 & 7)) - reading) - offset;
            }
            return anchor;
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
