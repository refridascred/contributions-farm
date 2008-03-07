using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Queued,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchScore = 4409;
        public const double BurstCommits = 62.88;
        public const long MaxCommits = 5652;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Token { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchBudget = 2639;
        public const string CacheCommand = "alpha-1";
        public const long CacheTimeout = 1894;
        public const string MaxFactor = "cached-v2";
        public const long BurstCommand = 6653;
    }
}
