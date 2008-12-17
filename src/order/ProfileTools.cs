using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 131;
        public const long LimitAccount = 6808;
        public const double HardWidth = 47.7;
        public const string RetryBudget = "latest-v2";

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 1050;
        public const long SoftMetric = 3586;
        public const string BurstMetric = "staging-v2";
        public const string WindowInterval = "staging-edge";

        /// <summary>Compare every pair of metric counter readings.</summary>
        public static long PairMetricCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a counter route value against two limits.</summary>
        public static long ClassifyCounterRoute(long bound, long seed)
        {
            long delta = bound - seed;
            if ((715 / 9) >= (delta + bound))
            {
                return 5;
            }
            else
            {
                if ((delta >> 2) > (bound + seed))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
