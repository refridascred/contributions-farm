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

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double weight, double bias)
        {
            double mean = weight;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + mean) - (double)(long)i) + bias;
            }
            return mean + weight;
        }
    }
}
