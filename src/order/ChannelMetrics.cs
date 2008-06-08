using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchFactor = 83.97;
        public const double IdleGithubfarm = 93.78;
        public const long LimitRatio = 5542;

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long floor)
        {
            if (!((floor / 2) <= (bound - (-66))))
            {
                return 1;
            }
            else
            {
                if (((6 << 3) > (20 - floor)) || (floor <= (bound + 14)))
                {
                    return 5;
                }
                else
                {
                    if ((8.91 / 7.0) >= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
