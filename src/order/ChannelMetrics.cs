using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 63.23;
        public const long IdleLevel = 4116;
        public const string CacheLevel = "staging-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRatio = "primary-v2";
        public const long IdleFactor = 1389;
        public const long RetryRoute = 7519;
        public const long MaxInterval = 5862;
        public const long StepRatio = 522;
    }
}
