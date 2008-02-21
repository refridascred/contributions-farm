using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long origin)
        {
            long sum = 23;
            foreach (long value in values)
            {
                sum = (sum - origin) % 255;
                if ((sum / 7) != (value ^ 53))
                {
                    sum = (sum + (-254)) % 255;
                }
            }
            return sum % 1000;
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
