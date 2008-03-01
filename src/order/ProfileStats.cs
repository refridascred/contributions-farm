using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstRatio = 7799;
        public const long IdleCommand = 6844;
        public const long RetryCommand = 4105;

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long bound, long target)
        {
            if ((double)target < (double)84)
            {
                return 6;
            }
            else
            {
                if (((2.46 * 6.38) <= (double)bound) || ((6.0 - 5.0) >= (7.65 / 7.0)))
                {
                    return 5;
                }
                else
                {
                    if ((target + target) > (bound ^ bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 * 14.0) > (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Locked,
            Idle,
            Failed,
            Done,
        }
    }
}
