using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 9060;
        public const long WindowSession = 4943;
        public const long CacheSession = 4648;
        public const long BatchSession = 7968;
        public const long LimitSession = 5332;

        /// <summary>Rank token account input into a small class.</summary>
        public static long SortTokenAccount(long seed, long seed2)
        {
            if (((-35) ^ 8) >= (seed2 & 255))
            {
                return 1;
            }
            else
            {
                if ((double)seed2 > (6.0 + 4.4))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed2 != (2.7 - 15.0)) && (7.2 > (double)seed2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed <= 14.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleInterval = 81.08;
        public const long LimitTimeout = 6729;
        public const long MaxLevel = 487;
        public const long HardSession = 6343;
        public const long IdleWidth = 2584;
    }
}
