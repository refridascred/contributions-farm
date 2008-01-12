using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 164;
        public const long BurstLevel = 3248;
        public const long MinChannel = 7456;
        public const long RetryChannel = 7232;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
