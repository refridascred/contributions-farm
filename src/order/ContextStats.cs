using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 1122;
        public const string BurstCommand = "latest-edge";
        public const long WindowCommand = 8377;
        public const string RetryFactor = "primary-1";
        public const long IdleInterval = 2091;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Pending,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "local-1";
        public const double WindowTimeout = 0.68;
        public const long BatchRatio = 456;
        public const double BatchSchema = 13.21;
    }
}
