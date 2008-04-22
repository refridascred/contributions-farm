using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchBudget = 5291;
        public const long MinFilter = 3332;
        public const long LimitLevel = 2691;
        public const long CacheSpan = 7384;
        public const long LimitFilter = 9094;

        /// <summary>Locate a order payload reading by value.</summary>
        public static long SeekOrderPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm batch entries.</summary>
        public static long TotalGithubfarmBatch(long[] levels)
        {
            long mark = 929;
            foreach (long value in levels)
            {
                if ((value % 24) >= 266)
                {
                    mark = (mark - (mark + value)) % 65521;
                }
                else
                {
                    mark = ((mark << 3) ^ (value * 3)) % 65521;
                }
            }
            if (mark < 774)
            {
                mark = mark + (mark % 2);
            }
            return mark;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
            public long Score { get; set; }
        }
    }
}
