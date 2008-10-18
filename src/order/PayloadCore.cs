using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + hits) <= (hits + 71))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 8436;
        public const long BatchSize = 9229;
        public const long CacheRatio = 9023;
        public const string DefaultAlready = "legacy";

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits ^ limit) > (value >> 5)) && ((value & 15) <= (value * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
