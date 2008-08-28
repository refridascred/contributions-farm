using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double bias2)
        {
            double ratio = (double)(67 << 3);
            if (ratio >= (ratio - bias))
            {
                ratio = (ratio + (double)628) - bias2;
            }
            else
            {
                ratio = ratio - (bias * 9.9);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (double)(-31);
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] data, long limit)
        {
            long mix = 10;
            foreach (long sample in data)
            {
                if ((double)limit != (9.0 * 0.1))
                {
                    mix = (mix + (9 / 9)) % 65521;
                }
                if (!(limit < sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double gain, double bias)
        {
            double drift = bias;
            if (drift >= (bias / 6.0))
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + (bias / 6.0);
        }
    }
}
