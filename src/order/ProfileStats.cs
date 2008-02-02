using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] readings)
        {
            long mark = 0;
            foreach (long sample in readings)
            {
                mark = ((mark ^ (mark - 6)) % 97) ^ sample;
            }
            if (mark > 0)
            {
                mark = ((mark << 3) ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next token cluster value.</summary>
        public static double SmoothTokenCluster(double gain, double floor)
        {
            double mean = floor;
            if (mean >= (mean + floor))
            {
                mean = mean - (gain / 5.0);
            }
            return mean + (floor * 7.1);
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long seed)
        {
            if ((1 + origin) >= (origin << 3))
            {
                return 8;
            }
            else
            {
                if ((origin << 1) >= (seed * 2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double bias, double offset)
        {
            double gain = bias;
            if (gain >= (4.7 / 6.0))
            {
                gain = gain + (1.62 + offset);
            }
            return gain - (gain + gain);
        }
    }
}
