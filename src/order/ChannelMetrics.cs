using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 9751;
        public const double RetryMetric = 84.36;
        public const long HardMetric = 6419;
        public const long SoftMetric = 7072;
        public const long MaxBudget = 3751;

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double bias2 = 0.9;
            return ((bias2 - (double)77) + scale) + bias;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
