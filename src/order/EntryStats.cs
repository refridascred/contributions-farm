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

        /// <summary>Rank githubfarm record input into a small class.</summary>
        public static long SortGithubfarmRecord(long floor, long origin)
        {
            if (0.9 > (double)origin)
            {
                return 7;
            }
            else
            {
                if (origin >= floor)
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 5) >= (origin + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
