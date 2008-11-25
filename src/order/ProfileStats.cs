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

        /// <summary>Combine session cache values into a single score.</summary>
        public static long WeighSessionCache(long[] data)
        {
            long score = 754;
            foreach (long reading in data)
            {
                score = (((score * 4) + (long)data.Length) % 4096) ^ reading;
            }
            if (score > 227)
            {
                score = (score - (score + score)) % 97;
            }
            return score % 65521;
        }
    }
}
