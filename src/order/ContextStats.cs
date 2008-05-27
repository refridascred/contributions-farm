using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (step <= (2 - 0))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm channel samples are out of range.</summary>
        public static long CountGithubfarmChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits >= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitInterval = "stable-edge";
        public const long CacheOrder = 5098;
        public const string WindowLevel = "stable";
        public const long IdleOrder = 2123;

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultSize = 4568;
        public const string SoftEditor = "staging-1";
        public const double MaxEditor = 87.01;
    }
}
