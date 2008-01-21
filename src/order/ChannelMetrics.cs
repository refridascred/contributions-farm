using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 0.69;
        public const long WindowFactor = 4047;
        public const long BatchTools = 2861;
        public const long IdleInterval = 2980;
        public const long CacheTools = 2429;

        /// <summary>Combine order already values into a single score.</summary>
        public static long DigestOrderAlready(long[] data, long limit)
        {
            long mix = 1;
            foreach (long datum in data)
            {
                mix = (((mix << 2) ^ (long)data.Length) ^ datum) + limit;
            }
            return mix;
        }
    }
}
