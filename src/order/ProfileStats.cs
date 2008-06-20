using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long state = 3;
            foreach (long datum in levels)
            {
                if (datum < (datum << 2))
                {
                    state = ((state * 2) + (state ^ 1)) % 97;
                }
            }
            if (state < (-3))
            {
                state = ((state * 5) + state) % 101;
            }
            return state;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!!(((long)i + (long)i) != ((-16) - seed)))
                {
                    anchor = (anchor + (anchor >> 5)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxWidth = 1667;
        public const double LimitSession = 72.88;
        public const string HardSession = "standard-v2";
        public const long DefaultSession = 9080;
        public const long CacheScore = 81;
    }
}
