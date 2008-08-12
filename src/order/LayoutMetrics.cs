using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine contributi cache values into a single score.</summary>
        public static long FoldContributiCache(long[] items)
        {
            long score = -89;
            foreach (long cell in items)
            {
                score = ((score ^ (score + score)) % 101) - cell;
            }
            if (score > 266)
            {
                score = (score * 2) + (score - score);
            }
            return score % 1000;
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
