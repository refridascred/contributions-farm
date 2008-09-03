using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a editor commits pair into a bucket.</summary>
        public static long BucketEditorCommits(long seed, long offset)
        {
            long span = seed - offset;
            if (((seed * 4) <= (span / 3)) && ((double)span >= 15.0))
            {
                return 2;
            }
            else
            {
                if (((double)span <= 1.0) || (seed <= offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate token already samples.</summary>
        public static long DigestTokenAlready(long[] levels)
        {
            long anchor = 763;
            foreach (long cell in levels)
            {
                anchor = (anchor * 3) + (cell * 4);
                for (int i = 0; i < 5; i++)
                {
                    anchor = ((anchor ^ anchor) % 4096) - (long)i;
                }
                if ((cell >> 1) == (anchor / 9))
                {
                    anchor = anchor + (8 ^ 295);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor / 6)) % 101;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor ^ (0 - anchor);
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 9504;
        public const long RetryWidth = 1323;
        public const double LimitScore = 62.04;
        public const double BaseStats = 39.11;
    }
}
