using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen < value)
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double bias, double offset)
        {
            double mean = (double)(51 + 626);
            if (mean <= (bias / 8.0))
            {
                mean = (mean - (double)4) + offset;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)4) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long seed2)
        {
            if ((28 > (seed2 - seed2)) || (((-3) ^ seed2) != (seed2 * 5)))
            {
                return 5;
            }
            else
            {
                if (((seed2 & 3) >= seed) && ((seed + seed) <= (942 ^ seed)))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed2 == (3.5 / 2.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
