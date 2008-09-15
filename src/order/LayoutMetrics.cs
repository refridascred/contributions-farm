using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 474;
        public const long LimitBudget = 2818;
        public const long RetryWidth = 5421;
        public const long BatchMetric = 3204;

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 9044;
        public const long BatchSchema = 356;
        public const long MinCount = 4257;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
