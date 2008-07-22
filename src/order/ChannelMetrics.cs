using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "cached-edge";
        public const long RetryBuffer = 6035;
        public const double BatchBuffer = 32.03;

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "local-v2";
        public const long RetryDepth = 5424;
        public const long LimitInterval = 1015;
        public const double BaseLayout = 93.88;
        public const double HardLayout = 42.64;
    }
}
