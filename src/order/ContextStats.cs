using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "staging-1";
        public const long CacheDepth = 7039;
        public const long IdleRatio = 5741;
        public const long MinCommand = 3878;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of support metric entries.</summary>
        public static long FoldSupportMetric(long[] samples, long bound)
        {
            long mix = 0;
            foreach (long value in samples)
            {
                mix = (((mix << 3) ^ mix) + value) + bound;
            }
            return mix % 97;
        }
    }
}
