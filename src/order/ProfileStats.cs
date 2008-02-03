using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Idle,
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long offset, long target)
        {
            if ((target + target) < (3 - target))
            {
                return 6;
            }
            else
            {
                if (((double)target != (6.29 + 4.86)) && ((offset + target) == (offset >> 2)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 861;
        public const long MaxAccount = 2211;
        public const long StepRatio = 2372;
        public const long IdleInterval = 2085;
    }
}
