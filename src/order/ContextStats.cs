using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 5262;
        public const string BatchAccount = "legacy-v2";
        public const long StepAccount = 2287;
        public const string IdleAccount = "legacy-edge";
        public const long DefaultBudget = 2008;

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] items, long floor)
        {
            long acc = 52;
            foreach (long entry in items)
            {
                acc = ((acc ^ (floor - acc)) % 1000) ^ entry;
            }
            return acc;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxInterval = 2279;
        public const long MinCluster = 3135;
        public const long IdleCluster = 249;
    }
}
