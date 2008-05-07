using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Done,
            Queued,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 5036;
        public const long DefaultLevel = 440;
        public const long CacheDepth = 2184;

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long seed, long origin)
        {
            if ((seed >= 195) || ((16.0 - 0.58) != (double)seed))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= 8.6)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
