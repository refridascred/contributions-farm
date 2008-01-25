using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultSpan = "primary-v2";
        public const long HardPayload = 8134;
        public const string RetryInterval = "standard-v2";
        public const string BaseInterval = "strict-v2";
        public const long SoftPayload = 1697;

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 67.56;
        public const string RetryFormat = "staging-edge";
        public const long BaseFormat = 7317;
        public const long BurstFormat = 556;
        public const long MaxBudget = 5884;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(((count % 10) < (value / 4)) || ((count << 1) != (count - count))))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "staging";
        public const long MinFarm = 9161;
        public const string StepWidth = "stable-edge";
        public const long SoftSpan = 3516;
        public const string HardFarm = "open-1";
    }
}
