using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] series, long seed)
        {
            long state = 88;
            foreach (long item in series)
            {
                state = (((state ^ (long)series.Length) % 4096) ^ item) - seed;
            }
            return state;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long target, long seed)
        {
            long cur = target - seed;
            if (!(cur > (-31)))
            {
                return 0;
            }
            else
            {
                if ((seed - target) <= cur)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 3.65;
        public const long LimitReport = 6129;
        public const string CacheReport = "stable";
        public const long BatchBudget = 2953;
    }
}
