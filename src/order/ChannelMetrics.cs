using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double bias = (offset + offset) + (offset * 1.24);
            if (bias <= (bias * 2.0))
            {
                bias = bias + (ratio - offset);
            }
            return bias - offset;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                if (((-22) + (long)i) >= (step >> 5))
                {
                    mark = (mark - step) % 65521;
                }
                mark = (mark << 3) ^ (84 & 31);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark + ((long)i * 2)) % 97) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
