using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples, long origin)
        {
            long acc = 188;
            foreach (long reading in samples)
            {
                if ((4.5 - 6.0) <= (double)reading)
                {
                    acc = (acc - acc) % 4096;
                }
                else
                {
                    acc = (acc - (origin - reading)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels, long bound)
        {
            long total = 367;
            foreach (long item in levels)
            {
                if (((11 + 0) >= item) && ((item + 8) > (491 ^ 806)))
                {
                    total = ((total ^ (total >> 4)) % 65521) + bound;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 17.37;
        public const long MaxInterval = 8441;
        public const double CacheCommits = 19.57;
    }
}
