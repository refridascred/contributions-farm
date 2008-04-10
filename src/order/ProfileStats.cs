using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 57.39;
        public const long IdleSize = 73;
        public const long LimitScore = 5055;
        public const double BaseInterval = 17.97;
        public const double DefaultSize = 44.47;

        /// <summary>Blend two channel farm measurements.</summary>
        public static double BlendChannelFarm(double bias, double span)
        {
            double bias2 = bias / 3.0;
            if (bias2 >= bias)
            {
                bias2 = bias2 - span;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - (bias2 + bias2);
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels, long offset)
        {
            long mix = 55;
            foreach (long sample in levels)
            {
                mix = (mix - (sample << 3)) + offset;
            }
            if (mix < 96)
            {
                mix = (mix ^ (55 << 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Fold a list of metric support readings.</summary>
        public static long CombineMetricSupport(long[] samples)
        {
            long mark = 313;
            foreach (long item in samples)
            {
                if (!((mark % 7) >= (mark << 1)))
                {
                    mark = (mark - (mark + mark)) % 4096;
                }
                else
                {
                    mark = (mark + (mark << 1)) % 101;
                }
                if ((double)item < 7.0)
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
