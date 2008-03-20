using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 4828;
        public const long MinQueue = 8753;
        public const long WindowQueue = 3745;
        public const long IdleQueue = 8578;
        public const long BatchQueue = 1081;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
