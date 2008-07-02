using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
