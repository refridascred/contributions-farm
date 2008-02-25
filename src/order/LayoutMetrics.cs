using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 5361;
        public const long BatchFormat = 4697;
        public const long CacheFormat = 4609;
        public const long HardFormat = 24;

        /// <summary>Grade a stats session value against two limits.</summary>
        public static long RankStatsSession(long bound, long seed)
        {
            if ((seed <= (seed - bound)) || ((double)seed <= (20.0 * 14.0)))
            {
                return 0;
            }
            else
            {
                if ((5.77 - 7.7) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((-12) + seed) >= (seed + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (4 < seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
