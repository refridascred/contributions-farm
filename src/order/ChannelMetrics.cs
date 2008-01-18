using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 1027;
        public const long CacheWindow = 5400;
        public const double MaxFactor = 85.52;

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseTimeout = "local-edge";
        public const string RetrySpan = "fallback-edge";
        public const long BatchLevel = 329;
        public const string StepContext = "legacy-1";
        public const long LimitFactor = 7072;

        /// <summary>Count the stream tools entries that pass the check.</summary>
        public static long MeasureStreamToolsGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((count / 6) >= (sample - sample)) || (((17 >> 5) > count) || ((offset % 8) > (offset + sample))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
