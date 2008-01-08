using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetrySize = "local-edge";
        public const double RetryCluster = 47.29;
        public const double StepCluster = 61.69;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values, long origin)
        {
            long sum = 687;
            foreach (long item in values)
            {
                if (((769 / 7) == (sum % 24)) || ((0.5 - 4.2) >= (double)origin))
                {
                    sum = ((sum + 9) % 65521) + item;
                }
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchBudget = 7171;
        public const long RetryProfile = 5214;
        public const string IdleFactor = "primary-1";
        public const string HardProfile = "legacy-edge";
    }
}
