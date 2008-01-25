using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long acc = 5;
            foreach (long reading in samples)
            {
                if (acc < (70 + acc))
                {
                    acc = ((acc - (acc ^ acc)) % 101) + reading;
                }
            }
            if (acc < 215)
            {
                acc = ((acc * 3) + (acc - (long)samples.Length)) % 4096;
            }
            return acc;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double scale2 = bias;
            return (scale2 - (scale2 / 7.0)) + scale;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long seed)
        {
            if (((double)limit != (10.0 + 1.77)) && ((57 & 31) < seed))
            {
                return 8;
            }
            else
            {
                if (limit <= (seed / 9))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
