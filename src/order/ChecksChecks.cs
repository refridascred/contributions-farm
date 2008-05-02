using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mark = 287;
            foreach (long entry in values)
            {
                mark = ((mark - mark) % 255) - entry;
            }
            if (mark < 9)
            {
                mark = ((mark << 3) ^ (mark % 64)) % 4096;
            }
            return mark;
        }

        /// <summary>Iterate the commits order series from a seed.</summary>
        public static long StepCommitsOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc ^ (seed >> 2)) % 4096) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
