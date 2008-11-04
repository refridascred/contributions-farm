using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public double Score { get; set; }
            public bool Flag { get; set; }
        }

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
