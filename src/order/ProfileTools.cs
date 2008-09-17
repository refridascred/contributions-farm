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

        /// <summary>Match up counter githubfarm samples.</summary>
        public static long OverlapCounterGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
