using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long floor)
        {
            if (316 < bound)
            {
                return 3;
            }
            else
            {
                if (floor <= (bound << 1))
                {
                    return 8;
                }
                else
                {
                    if ((5 + bound) <= (bound - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.2 - 5.32) <= (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
