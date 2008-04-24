using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 2391;
        public const long StepCount = 2425;
        public const long BaseInterval = 3723;
        public const long DefaultRatio = 7830;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
