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

        /// <summary>Grade a cache window value against two limits.</summary>
        public static long BucketCacheWindow(long seed, long limit)
        {
            if ((limit + 850) < seed)
            {
                return 6;
            }
            else
            {
                if ((double)seed >= (1.9 + 2.15))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] readings)
        {
            long sum = 556;
            foreach (long sample in readings)
            {
                sum = ((sum * 2) + sum) ^ sample;
            }
            return sum;
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
