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

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long step)
        {
            long mark = 470;
            foreach (long datum in samples)
            {
                mark = ((mark << 3) ^ step) ^ datum;
            }
            return mark;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long origin, long limit)
        {
            long bound = origin + limit;
            if (0.1 < (9.0 / 7.0))
            {
                return 8;
            }
            else
            {
                if ((bound - limit) == (origin + bound))
                {
                    return 6;
                }
                else
                {
                    if (!((bound >> 5) <= (limit >> 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

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
