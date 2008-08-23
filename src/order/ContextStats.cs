using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 2943;
        public const long WindowRatio = 9817;
        public const long HardInterval = 1452;
        public const string CacheAccount = "primary-edge";
        public const double WindowAccount = 82.36;

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "standard-edge";
        public const long WindowDepth = 8749;
        public const double BurstSession = 57.67;
        public const long HardSize = 6339;
    }
}
