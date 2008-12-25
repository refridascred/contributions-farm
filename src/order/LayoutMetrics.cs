using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long CountWindowCounterOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((44 - sample) == (count >> 1))
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Synced,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseBudget = 2059;
        public const long BatchMetric = 3675;
        public const long MinMetric = 1163;
        public const long StepRatio = 6207;
    }
}
