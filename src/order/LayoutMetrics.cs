using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long bound, long origin)
        {
            long delta = bound + origin;
            if ((delta - 422) == (bound - delta))
            {
                return 2;
            }
            else
            {
                if ((delta - origin) == (origin + 99))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many batch filter samples are out of range.</summary>
        public static long CountBatchFilterGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((7.0 / 9.0) >= (1.06 - 16.0))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
