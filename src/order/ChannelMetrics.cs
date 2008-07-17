using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double bias = (double)(94 ^ 949);
            if (bias > (rate - offset))
            {
                bias = bias - rate;
            }
            else
            {
                bias = bias + (rate / 2.0);
            }
            return bias + (2.0 + 10.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBudget = 8134;
        public const string MaxRatio = "local-1";
        public const long IdleSpan = 8689;
        public const long CacheRatio = 3494;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 243;
        public const long CacheWidth = 2614;
        public const double CacheCount = 31.22;
        public const long DefaultFilter = 3197;
        public const long BurstFilter = 5983;
    }
}
