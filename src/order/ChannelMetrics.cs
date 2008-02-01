using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Synced,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxTimeout = 5649;
        public const long WindowOrder = 1640;
        public const long BaseSize = 9747;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}
