using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseTimeout = 1903;
        public const double WindowEditor = 79.36;
        public const long LimitEditor = 8307;
        public const long SoftEditor = 6424;
        public const string BurstBudget = "latest-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 787;
        public const long RetryMetric = 8461;
        public const long CacheMetric = 2051;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long origin, long bound)
        {
            if ((495 + bound) == (origin + origin))
            {
                return 6;
            }
            else
            {
                if (((double)origin != (4.2 + 9.78)) && ((double)bound != (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin >= (0.04 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
