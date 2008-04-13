using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheSize = 475;
        public const long RetryDepth = 5568;
        public const double BaseChecks = 33.1;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Active,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Weight { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
