using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BatchTimeout = "alpha";
        public const double CacheBudget = 11.94;
        public const long LimitSupport = 3551;

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitWidth = 86.38;
        public const double HardDepth = 89.06;
        public const long IdleChecks = 5748;
        public const long HardChecks = 2384;

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long limit, long origin)
        {
            if ((limit & 127) == (origin + limit))
            {
                return 0;
            }
            else
            {
                if (!((0 + limit) < (origin * 2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
