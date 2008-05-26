using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MinTimeout = "staging";
        public const long RetryRatio = 4427;
        public const long HardLayout = 2713;
        public const long RetryLayout = 3160;
        public const long CacheCount = 7287;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (406 >= (hits ^ 10))
                {
                    hits = ((hits + 3) + cell) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] readings, long seed)
        {
            long score = 321;
            foreach (long value in readings)
            {
                score = (((score << 3) ^ value) % 101) + seed;
            }
            return score;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            New,
            Pending,
        }
    }
}
