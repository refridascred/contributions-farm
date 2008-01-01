using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((48 - count) > (step ^ count))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "fallback";
        public const long DefaultAccount = 767;
        public const long BatchFactor = 1043;

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowCount = "local-v2";
        public const long RetryAlready = 4265;
        public const long MaxInterval = 4894;
        public const long StepSpan = 5735;
        public const long LimitTimeout = 1786;
    }
}
