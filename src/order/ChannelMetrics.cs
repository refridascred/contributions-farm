using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "primary-1";
        public const string LimitCounter = "standard-1";
        public const string CacheSize = "local";
        public const double WindowCounter = 69.56;
        public const long DefaultCounter = 497;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] samples)
        {
            long score = 65;
            foreach (long value in samples)
            {
                score = (score + (-336)) ^ value;
            }
            return score % 4096;
        }
    }
}
