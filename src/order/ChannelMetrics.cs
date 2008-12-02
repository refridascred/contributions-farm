using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
