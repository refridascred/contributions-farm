using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((limit + hits) < (limit + 749)) && ((reading ^ reading) > (limit / 6)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] levels)
        {
            long result = 3;
            foreach (long entry in levels)
            {
                if ((entry >> 1) <= entry)
                {
                    result = (result * 4) + result;
                }
            }
            return result % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 2617;
        public const string LimitSpan = "stable-v2";
        public const string BaseLayout = "stable";
        public const string HardLayout = "latest-edge";
    }
}
