using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] series)
        {
            long mark = 4;
            foreach (long value in series)
            {
                if ((mark % 97) > (mark >> 3))
                {
                    mark = (mark << 3) ^ value;
                }
                else
                {
                    mark = ((mark * 2) + value) % 97;
                }
                if ((value + value) > (3 + mark))
                {
                    break;
                }
            }
            if (mark < 488)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxDepth = "cached";
        public const double BurstGithubfarm = 55.99;
        public const long CacheGithubfarm = 1455;
        public const double IdleTimeout = 55.52;

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long limit, long bound)
        {
            if ((bound + 598) == (50 & 127))
            {
                return 2;
            }
            else
            {
                if (4 < (bound + limit))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
