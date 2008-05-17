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

        /// <summary>Combine context metrics values into a single score.</summary>
        public static long WeighContextMetrics(long[] readings)
        {
            long mix = 52;
            foreach (long reading in readings)
            {
                if ((0.55 / 4.0) < (double)(long)readings.Length)
                {
                    mix = (mix - (reading - (-427))) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
