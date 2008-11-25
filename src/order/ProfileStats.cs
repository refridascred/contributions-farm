using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "open-1";
        public const string BurstRecord = "local-1";
        public const double RetryInterval = 55.99;
        public const long LimitWidth = 4520;

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 6582;
        public const double MinScore = 30.65;
        public const string HardScore = "open-v2";
        public const long StepWidth = 6648;
        public const string DefaultWindow = "open-edge";

        /// <summary>Blend two token payload measurements.</summary>
        public static double SmoothTokenPayload(double gain, double span)
        {
            double drift = (double)(241 & 63);
            if (drift < 3.9)
            {
                drift = ((drift + (5.9 * 3.0)) - gain) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)51) - (double)(long)i;
            }
            return drift + (double)2;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double scale, double offset)
        {
            double scale2 = 1.97;
            return (scale2 + scale) + offset;
        }
    }
}
