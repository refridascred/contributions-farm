using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values)
        {
            long mix = 783;
            foreach (long reading in values)
            {
                if ((1.02 <= (double)mix) || ((1.96 * 9.0) < (6.93 * 3.37)))
                {
                    mix = (mix - (reading & 15)) % 1000;
                }
                else
                {
                    mix = (mix + (reading << 3)) % 97;
                }
            }
            if (mix < 57)
            {
                mix = ((mix * 2) + mix) % 97;
            }
            return mix % 97;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
