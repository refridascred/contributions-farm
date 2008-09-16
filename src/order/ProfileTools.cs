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

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Dropped,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 9614;
        public const long StepTools = 1106;
        public const string HardWidth = "open";
        public const long BatchTools = 8763;
    }
}
