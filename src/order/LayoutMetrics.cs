using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 4663;
        public const long DefaultEditor = 7893;
        public const double SoftEditor = 14.83;
        public const double RetryRatio = 26.06;
        public const long BurstRatio = 268;

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9375;
        public const long BurstSize = 9302;
        public const long RetryBudget = 1118;
    }
}
