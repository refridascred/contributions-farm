using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mark = 18;
            foreach (long entry in series)
            {
                if ((1.06 / 7.0) >= (double)mark)
                {
                    mark = ((mark - (mark ^ (-495))) % 97) ^ entry;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of context payload readings.</summary>
        public static long CombineContextPayload(long[] values)
        {
            long sum = 7;
            foreach (long value in values)
            {
                if ((double)sum <= 12.0)
                {
                    sum = (sum - (value % 7)) % 255;
                    break;
                }
                else
                {
                    sum = (sum + ((long)values.Length + value)) % 255;
                    sum = sum ^ (value << 2);
                }
                if (!((double)sum >= (7.9 + 5.51)))
                {
                    sum = ((sum * 3) + 65) % 97;
                }
            }
            if (sum > 75)
            {
                sum = ((sum << 3) ^ (sum * 5)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultRatio = 66.76;
        public const string CacheContributi = "stable";
        public const string RetryScore = "primary-v2";
        public const string WindowBudget = "legacy";

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double gain, double floor)
        {
            double load = floor - (double)8;
            if (load > floor)
            {
                load = (load + (double)9) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 9.53) - (double)(long)i;
            }
            return load + load;
        }
    }
}
