using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowWidth = 6705;
        public const double CacheWidth = 52.52;
        public const long WindowCounter = 8908;
        public const long MaxInterval = 4786;

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
