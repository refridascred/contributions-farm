using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardBudget = 9.37;
        public const long BaseToken = 6133;
        public const double BatchToken = 76.22;
        public const long MaxSpan = 8346;
        public const double BatchRatio = 17.02;

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 2559;
        public const long BatchBudget = 4580;
        public const long LimitScore = 5456;
        public const long RetryFactor = 269;
        public const long HardCommand = 5704;
    }
}
