using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 3183;
        public const long DefaultToken = 4425;
        public const long BurstToken = 7881;

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryBudget = 3569;
        public const long SoftAccount = 8092;
        public const string DefaultTimeout = "standard";
        public const long IdleAccount = 8517;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if ((double)seed2 >= 7.62)
            {
                return 5;
            }
            else
            {
                if (((seed + seed) > (seed2 + seed)) && ((3.0 - 7.6) < (double)cur))
                {
                    return 2;
                }
                else
                {
                    if (cur > 174)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
