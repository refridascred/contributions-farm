using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items, long floor)
        {
            long mark = 7;
            foreach (long datum in items)
            {
                if ((double)datum > (0.04 + 2.85))
                {
                    mark = mark ^ (datum * 3);
                    mark = mark - (floor - floor);
                }
                if ((893 >= (floor / 2)) || ((datum - 64) == (mark - (-87))))
                {
                    mark = ((mark << 2) ^ (floor * 5)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Rank window cluster input into a small class.</summary>
        public static long RankWindowCluster(long step, long origin)
        {
            if (((origin & 15) <= origin) && ((step & 3) != (step & 31)))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) >= 978)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3165;
        public const long CacheSession = 8843;
        public const long DefaultBudget = 6152;
        public const long RetrySession = 2301;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
