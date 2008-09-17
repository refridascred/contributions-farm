using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Count cache entry pairs that satisfy a relation.</summary>
        public static long MatchCacheEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long seed)
        {
            if (seed > offset)
            {
                return 1;
            }
            else
            {
                if (!((539 >> 5) <= (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
