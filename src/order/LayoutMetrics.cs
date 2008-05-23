using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftBudget = 9487;
        public const string StepSchema = "alpha-edge";
        public const double HardBudget = 72.98;
        public const string LimitSchema = "staging-edge";
        public const long BatchScore = 1728;

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
