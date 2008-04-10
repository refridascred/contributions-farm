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

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepSize = "staging-v2";
        public const long IdleRatio = 2821;
        public const long MaxSpan = 5939;
        public const string BaseFarm = "primary-edge";
    }
}
