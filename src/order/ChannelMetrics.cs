using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 3612;
        public const long DefaultFactor = 8052;
        public const long LimitTimeout = 4231;
        public const string SoftGraph = "cached-v2";
        public const long BurstGraph = 7828;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits / 7) == (817 + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record route entries.</summary>
        public static long TotalRecordRoute(long[] values, long bound)
        {
            long score = 80;
            foreach (long cell in values)
            {
                score = (((score - (score - score)) % 4096) + cell) + bound;
            }
            return score;
        }
    }
}
