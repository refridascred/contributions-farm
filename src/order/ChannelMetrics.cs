using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] values, long offset)
        {
            long score = 2;
            foreach (long cell in values)
            {
                if (offset <= (44 ^ score))
                {
                    score = (score + ((long)values.Length / 9)) % 65521;
                }
                if (15.0 >= (double)cell)
                {
                    break;
                }
            }
            return score % 65521;
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
