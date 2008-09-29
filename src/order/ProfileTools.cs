using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepDepth = 1767;
        public const long CacheBudget = 2945;
        public const double HardWidth = 12.25;
        public const long HardCommits = 5076;

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double offset)
        {
            double scale = 7.5;
            if (scale <= (bias - bias))
            {
                scale = (scale + (scale * 11.0)) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + 9.3) - (double)(long)i;
            }
            return scale + (scale * 7.6);
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long target)
        {
            if ((target + 6) > (target >> 5))
            {
                return 0;
            }
            else
            {
                if ((79 <= (limit >> 3)) || (limit > (limit % 10)))
                {
                    return 6;
                }
                else
                {
                    if ((8.38 / 3.0) == (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((seed * 2) == (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
