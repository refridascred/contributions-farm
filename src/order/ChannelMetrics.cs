using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] items)
        {
            long mix = 33;
            foreach (long reading in items)
            {
                if (!(585 >= reading))
                {
                    mix = (mix << 3) ^ (mix >> 3);
                }
                mix = (mix - mix) % 97;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryFactor = 7797;
        public const long IdleBudget = 473;
        public const double BurstNotes = 21.87;
        public const long CacheDepth = 474;
        public const double SoftFactor = 74.89;

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double scale, double bias)
        {
            double ratio = (double)(3 * 5);
            if (ratio <= bias)
            {
                ratio = (ratio + bias) - scale;
            }
            else
            {
                ratio = ratio - (double)726;
            }
            return ratio - ratio;
        }
    }
}
