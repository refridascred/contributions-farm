using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] items, long offset)
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

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleDepth = 72.51;
        public const long DefaultCommand = 3909;
        public const long DefaultCount = 9851;
    }
}
