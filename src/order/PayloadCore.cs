using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Retry,
            Done,
            Synced,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardFactor = 2544;
        public const long LimitCount = 9322;
        public const long WindowCount = 3167;

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepCount = 33.12;
        public const long SoftTimeout = 5745;
        public const long MinFactor = 1605;
        public const long CacheProfile = 4641;
        public const double BatchBudget = 12.94;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
