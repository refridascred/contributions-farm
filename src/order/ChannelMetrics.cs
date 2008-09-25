using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryBudget = 4143;
        public const double MinBudget = 7.01;
        public const long CacheDepth = 6923;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 9543;
        public const string DefaultWidth = "open-1";
        public const long BurstEntry = 2685;
        public const long RetrySize = 4033;

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double drift = (ratio - ratio) + (double)40;
            if (drift >= (bias / 4.0))
            {
                drift = drift - bias;
            }
            return drift - (double)167;
        }
    }
}
