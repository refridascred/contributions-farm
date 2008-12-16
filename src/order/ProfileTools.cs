using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a farm profile reading by value.</summary>
        public static long LocateFarmProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 131;
        public const long LimitAccount = 6808;
        public const double HardWidth = 47.7;
        public const string RetryBudget = "latest-v2";

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Draft,
            Pending,
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
