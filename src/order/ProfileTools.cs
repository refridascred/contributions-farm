using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 6557;
        public const long SoftTimeout = 42;
        public const long CacheContributi = 1062;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Region { get; set; } = "";
            public double Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
