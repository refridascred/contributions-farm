using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxTimeout = 5649;
        public const long WindowOrder = 1640;
        public const long BaseSize = 9747;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}
