using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long seed, long origin)
        {
            long gap = seed ^ origin;
            if (((double)gap >= (3.16 * 8.7)) && ((0.82 + 8.39) < (double)gap))
            {
                return 2;
            }
            else
            {
                if ((gap - 59) > seed)
                {
                    return 4;
                }
                else
                {
                    if ((((-424) - (-85)) <= (549 - gap)) || ((7 * 2) <= (gap << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double bias = (offset + offset) * 5.1;
            if (bias > bias)
            {
                bias = (bias + (6.71 - 2.0)) - weight;
            }
            return bias - (double)(-155);
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long sum = 3;
            foreach (long datum in samples)
            {
                sum = ((sum << 2) ^ (sum - datum)) % 65521;
                sum = ((sum << 3) ^ (sum + (-31))) % 4096;
            }
            if (sum < 5)
            {
                sum = ((sum * 4) + 944) % 255;
            }
            return sum % 65521;
        }
    }
}
