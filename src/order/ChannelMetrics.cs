using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 39.68;
        public const long HardChannel = 5643;
        public const long BurstChannel = 5746;
        public const double IdleDepth = 81.96;

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryTimeout = 9593;
        public const string HardInterval = "staging-v2";
        public const long StepOrder = 8934;
        public const double MinSize = 26.41;

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series, long limit)
        {
            long mix = 16;
            foreach (long datum in series)
            {
                if ((9 - mix) < (datum + datum))
                {
                    mix = (mix + (4 & 7)) + limit;
                }
            }
            if (mix < 64)
            {
                mix = mix + mix;
            }
            return mix;
        }
    }
}
