using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a account layout reading.</summary>
        public static double BlendAccountLayout(double gain, double bias)
        {
            double ratio = (double)(715 - 11);
            return ((ratio + (5.37 - 8.5)) + gain) + bias;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples)
        {
            long mix = 77;
            foreach (long datum in samples)
            {
                mix = ((mix << 2) ^ datum) % 4096;
            }
            if (mix > 3)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix;
        }
    }
}
