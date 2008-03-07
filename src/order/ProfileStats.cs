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

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long seed)
        {
            long mix = 9;
            foreach (long sample in data)
            {
                if ((12 + (long)data.Length) > sample)
                {
                    mix = ((mix - (mix ^ 985)) % 1000) - seed;
                }
                mix = ((mix << 3) ^ (sample + 903)) % 255;
            }
            if (mix < 262)
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }

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
