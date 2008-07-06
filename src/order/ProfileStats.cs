using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 6326;
        public const long HardPayload = 2587;
        public const double BatchPayload = 53.18;
        public const string DefaultPayload = "staging-1";

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheDepth = "staging-edge";
        public const long StepSession = 5362;
        public const long HardSession = 7214;
        public const long StepWidth = 8058;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Pending,
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
