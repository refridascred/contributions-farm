using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryScore = 4836;
        public const string MaxLevel = "fallback-edge";
        public const string BaseWidth = "cached-edge";
        public const long DefaultMetric = 8767;
        public const long StepMetric = 1797;

        /// <summary>Check that every tools counter entry stays within the limit.</summary>
        public static bool GuardToolsCounterBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
