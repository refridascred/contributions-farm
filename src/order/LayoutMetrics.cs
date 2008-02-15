using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleDepth = 7058;
        public const long RetrySize = 6778;
        public const double BurstLevel = 54.2;
        public const long DefaultTimeout = 9684;
        public const long BaseBudget = 6795;

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] values, long seed)
        {
            long mix = 22;
            foreach (long reading in values)
            {
                if ((7.0 + 5.2) == (double)seed)
                {
                    mix = (((mix * 4) + (seed - 67)) % 255) + reading;
                }
                mix = (mix << 2) ^ seed;
            }
            return mix;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Closed,
            Paused,
            Failed,
        }
    }
}
