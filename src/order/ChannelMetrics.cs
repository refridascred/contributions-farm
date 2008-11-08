using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 25.36;
        public const long MaxTools = 7915;
        public const double RetryWidth = 92.65;
        public const string SoftRatio = "strict-edge";

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long bound2)
        {
            if (((bound + 41) < bound2) || (bound2 < (bound2 ^ 225)))
            {
                return 4;
            }
            else
            {
                if ((19.0 - 1.17) < (double)bound2)
                {
                    return 8;
                }
                else
                {
                    if (((bound2 & 15) < ((-5) - bound2)) && ((0.6 + 9.22) >= (double)bound2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound - bound2) > (bound2 * 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metric filter input into a small class.</summary>
        public static long BucketMetricFilter(long step, long seed)
        {
            long offset = step - seed;
            if (!((13.0 * 18.0) < (double)offset))
            {
                return 6;
            }
            else
            {
                if (((-8) >= (step + seed)) && ((seed + seed) >= (offset + offset)))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset == (4.31 - 11.0)) && ((step % 8) == (step + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
