using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double scale, double floor)
        {
            double weight = 1.4;
            return (weight - scale) + floor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxRatio = 4107;
        public const long RetryRatio = 2923;
        public const long RetryOrder = 8506;
        public const string CacheOrder = "latest-1";
        public const double DefaultDepth = 81.0;
    }
}
