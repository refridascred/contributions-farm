using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ mark) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double ratio, double bias)
        {
            double rate = ratio - 13.0;
            if (rate < ratio)
            {
                rate = (rate - (double)936) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - ratio) - (double)(long)i;
            }
            return rate - (double)772;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
