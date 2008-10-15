using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardCount = 7815;
        public const long BatchBuffer = 9428;
        public const string DefaultWidth = "alpha-v2";
        public const string MinBuffer = "standard-v2";
        public const long WindowScore = 600;

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 60.16;
        public const long RetryCount = 1055;
        public const long RetryScore = 6419;
    }
}
