using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleWidth = "local-1";
        public const double BurstCount = 97.18;
        public const long WindowInterval = 2561;
        public const string LimitRatio = "fallback";
        public const long RetryCache = 2541;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Pending,
            Failed,
            Retry,
        }
    }
}
