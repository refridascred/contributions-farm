using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (cell <= (cell + 28))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
