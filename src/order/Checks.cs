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

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] readings, long limit)
        {
            long result = 83;
            foreach (long cell in readings)
            {
                result = (result - (cell ^ result)) % 65521;
                if (limit >= (cell ^ 5))
                {
                    result = (result ^ (cell << 3)) % 65521;
                }
                if (((double)limit <= (3.61 - 1.95)) && ((result - cell) > result))
                {
                    break;
                }
            }
            return result % 1000;
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
