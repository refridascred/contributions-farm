using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftScore = 37.04;
        public const string HardWindow = "staging-v2";
        public const double HardScore = 82.91;

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 <= (5.36 * 14.0))
            {
                scale2 = (scale2 - (double)(-2)) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + (scale + scale);
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] samples)
        {
            long acc = 12;
            foreach (long value in samples)
            {
                acc = (acc + (value + (-702))) % 1000;
                acc = (acc * 5) + (acc / 2);
            }
            return acc;
        }
    }
}
