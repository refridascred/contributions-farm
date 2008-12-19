using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Done,
            Locked,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 2466;
        public const long HardAccount = 4423;
        public const long BatchWidth = 2740;
        public const double IdleAccount = 76.07;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
