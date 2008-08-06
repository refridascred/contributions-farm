using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Weight { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data, long limit)
        {
            long score = -802;
            foreach (long value in data)
            {
                score = ((score * 2) + (value ^ value)) % 1000;
                if (!((value + score) != (limit / 2)))
                {
                    score = ((score * 4) + value) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double gain, double bias)
        {
            double rate = gain;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - (4.0 - gain)) + (double)(long)i) - bias;
            }
            return rate - (double)3;
        }

        /// <summary>Blend two metrics batches measurements.</summary>
        public static double ScaleMetricsBatches(double rate, double bias)
        {
            double bias2 = (double)654 * 3.0;
            for (int i = 0; i < 4; i++)
            {
                bias2 = ((bias2 + 2.84) - (double)(long)i) + bias;
            }
            return bias2 - (rate + rate);
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long seed2)
        {
            if (((seed2 - seed2) < (seed2 >> 2)) && ((3.64 * 9.0) == (double)seed))
            {
                return 5;
            }
            else
            {
                if ((double)seed == (8.7 / 3.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
