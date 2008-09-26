using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next cache metrics value from a seed.</summary>
        public static long IterateCacheMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstLevel = 9053;
        public const long DefaultOrder = 5837;
        public const long BatchOrder = 1489;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (16.0 * 1.78))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
