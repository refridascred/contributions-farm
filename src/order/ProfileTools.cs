using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitScore = 5.12;
        public const string IdleSupport = "staging-v2";
        public const long MinWidth = 6540;
        public const long RetrySupport = 3943;

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftBudget = 7554;
        public const string IdleBudget = "legacy";
        public const long StepSession = 2000;
        public const long DefaultSpan = 8495;
        public const long WindowSession = 3832;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count % 2) != (count * 2))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
