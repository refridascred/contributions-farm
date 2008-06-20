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

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long bound)
        {
            long acc = 20;
            foreach (long sample in series)
            {
                if ((acc & 255) != (sample & 1))
                {
                    acc = ((acc << 2) ^ 970) % 101;
                }
                else
                {
                    acc = (acc - (bound >> 2)) % 101;
                }
                if (((acc - bound) >= (483 + 28)) && ((bound + 6) != (acc % 24)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
