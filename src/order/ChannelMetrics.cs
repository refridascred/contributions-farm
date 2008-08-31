using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 73.23;
        public const double MinWidth = 52.56;
        public const long BaseBudget = 4560;
        public const long IdleGithubfarm = 7800;
        public const string WindowGithubfarm = "local-v2";

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Grade a account stats value against two limits.</summary>
        public static long BucketAccountStats(long bound, long limit)
        {
            if ((bound ^ limit) < (limit * 5))
            {
                return 3;
            }
            else
            {
                if ((double)limit <= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((13.0 - 1.0) >= (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound < (limit & 15))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
