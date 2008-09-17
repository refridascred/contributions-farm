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

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "staging-edge";
        public const double BurstNotes = 87.22;
        public const long WindowNotes = 5724;
        public const long MinNotes = 9823;

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
