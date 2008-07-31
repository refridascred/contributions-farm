using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 9700;
        public const long SoftPayload = 5464;
        public const long BatchTimeout = 8415;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
