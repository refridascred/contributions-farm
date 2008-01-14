using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double weight, double offset)
        {
            double rate = 2.0;
            if (rate < weight)
            {
                rate = (rate - weight) - offset;
            }
            return rate + weight;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 2) ^ 34;
                if (!!(acc > ((long)i >> 3)))
                {
                    acc = acc - 785;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double mean = scale;
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
