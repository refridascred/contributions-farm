using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double scale, double bias)
        {
            double mean = bias;
            if (mean <= (scale / 3.0))
            {
                mean = mean - (double)(-41);
            }
            else
            {
                mean = mean + (bias - mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Rank queue layout input into a small class.</summary>
        public static long BucketQueueLayout(long floor, long target)
        {
            if ((target + target) == (floor * 3))
            {
                return 1;
            }
            else
            {
                if (6.3 >= (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((floor & 255) >= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
