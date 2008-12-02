using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long limit, long target)
        {
            if ((target & 31) > (limit >> 4))
            {
                return 6;
            }
            else
            {
                if (((14.0 / 4.0) > (double)target) && ((target - 4) != (1 >> 1)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double weight, double bias)
        {
            double rate = weight * 4.8;
            if (rate > (weight + weight))
            {
                rate = rate + (bias - 0.77);
            }
            else
            {
                rate = rate + (2.0 - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
