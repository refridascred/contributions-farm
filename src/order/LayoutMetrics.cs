using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!!(917 > (item / 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long offset)
        {
            if ((820 >> 4) >= seed)
            {
                return 5;
            }
            else
            {
                if (offset >= (seed - 453))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine entry contributi values into a single score.</summary>
        public static long CombineEntryContributi(long[] series, long target)
        {
            long acc = 981;
            foreach (long cell in series)
            {
                acc = (acc ^ cell) % 1000;
                if ((double)cell != (1.0 * 0.1))
                {
                    acc = (acc - (acc + (-31))) % 101;
                }
                if (((5.9 * 1.0) > 5.7) || ((cell - target) > (cell - acc)))
                {
                    acc = (acc + (cell % 2)) % 97;
                }
                else
                {
                    acc = (acc ^ target) % 97;
                }
            }
            return acc;
        }
    }
}
