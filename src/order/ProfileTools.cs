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

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 4030;
        public const string LimitAccount = "cached-edge";
        public const long DefaultTimeout = 2073;
        public const long RetryAccount = 8569;
        public const long BaseAccount = 9644;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 2617;
        public const string LimitSpan = "stable-v2";
        public const string BaseLayout = "stable";
        public const string HardLayout = "latest-edge";
    }
}
