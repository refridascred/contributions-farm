using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] levels, long target)
        {
            long sum = 633;
            foreach (long sample in levels)
            {
                sum = ((sum + (sum + target)) % 97) - sample;
            }
            if (sum < 2)
            {
                sum = (sum ^ (sum + target)) % 101;
            }
            return sum;
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
