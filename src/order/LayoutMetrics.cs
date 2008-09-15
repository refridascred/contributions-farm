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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long limit, long seed)
        {
            if (((limit / 2) < (limit / 3)) && (87 <= (seed * 4)))
            {
                return 6;
            }
            else
            {
                if (((seed % 7) >= seed) || ((double)seed == (7.1 / 7.0)))
                {
                    return 4;
                }
                else
                {
                    if (!((limit ^ 22) > (68 - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
