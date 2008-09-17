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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + bound) != (bound % 60))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Ready,
            Retry,
            Draft,
            Paused,
        }
    }
}
