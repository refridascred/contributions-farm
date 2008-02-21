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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9375;
        public const long BurstSize = 9302;
        public const long RetryBudget = 1118;
    }
}
