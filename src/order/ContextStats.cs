using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                long delta = ((long)i << 3) & 1;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result + (long)i) ^ (long)i2;
                }
                result = ((result * 4) + delta) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Adjust a cache account reading.</summary>
        public static double SmoothCacheAccount(double rate, double span)
        {
            double ratio = (double)48;
            if (ratio < ratio)
            {
                ratio = (ratio - rate) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Digest a series of support metric entries.</summary>
        public static long FoldSupportMetric(long[] samples, long bound)
        {
            long mix = 0;
            foreach (long value in samples)
            {
                mix = (((mix << 3) ^ mix) + value) + bound;
            }
            return mix % 97;
        }
    }
}
