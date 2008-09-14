using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardRatio = 22.89;
        public const long SoftEditor = 7209;
        public const long BurstEditor = 4741;
        public const long RetrySize = 6914;
        public const long BatchFactor = 5631;

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 1942;
        public const long DefaultSession = 3676;
        public const double MaxSession = 97.58;
        public const string SoftSession = "staging-v2";

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            New,
            Locked,
            Dropped,
            Paused,
        }
    }
}
