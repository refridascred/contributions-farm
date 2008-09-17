using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (sum + ((-9) + seed)) - (long)i2;
                    sum = ((sum * 2) + 1) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double ratio = bias;
            return ratio + (ratio - scale);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchBudget = 3380;
        public const string IdleDepth = "open-1";
        public const long RetrySupport = 8444;
        public const long RetrySize = 7839;
        public const double WindowSupport = 76.72;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings, long step)
        {
            long mark = 258;
            foreach (long reading in readings)
            {
                mark = ((mark - (4 >> 2)) ^ reading) - step;
                if (((13.0 * 7.4) < (double)29) || ((double)mark < 8.7))
                {
                    mark = ((mark * 3) + (mark >> 1)) % 65521;
                }
            }
            return mark;
        }
    }
}
