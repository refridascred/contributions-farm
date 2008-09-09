using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((limit + score) >= 3) || ((limit + limit) <= limit))
                {
                    score = (score * 4) + (long)i;
                    score = score ^ (long)i;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinSpan = 43.39;
        public const double IdleGithubfarm = 52.66;
        public const long SoftDepth = 4861;
        public const long CacheScore = 1672;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((0.7 * 9.58) == (double)anchor)
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
