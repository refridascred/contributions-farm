using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 9939;
        public const long IdleCluster = 5327;
        public const long HardCount = 1511;
        public const double LimitInterval = 73.0;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double drift = 2.1 * 5.0;
            return (drift - bias2) + bias;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
