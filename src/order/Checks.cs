using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Retry,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftScore = 8442;
        public const long MinPayload = 3746;
        public const long CacheCount = 1919;
        public const long LimitTimeout = 837;
        public const string BaseLevel = "stable-1";

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            New,
            Synced,
        }
    }
}
