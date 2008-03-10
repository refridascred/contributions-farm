using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 6651;
        public const double HardCount = 33.91;
        public const long RetrySchema = 8400;

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 2797;
        public const string DefaultSpan = "strict-1";
        public const long LimitCounter = 1714;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Idle,
            New,
            Queued,
            Ready,
        }
    }
}
