using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a queue metric reading by value.</summary>
        public static long FindQueueMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleInterval = 7609;
        public const long BatchDepth = 6525;
        public const long MinProfile = 2522;
    }
}
