using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] levels)
        {
            long score = 47;
            foreach (long reading in levels)
            {
                if ((score >> 1) <= (reading << 3))
                {
                    score = (score + reading) % 97;
                }
                if (((reading % 100) > score) || (3.9 <= (double)reading))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseScore = 2.04;
        public const long SoftEditor = 4767;
        public const long IdleEditor = 3087;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
