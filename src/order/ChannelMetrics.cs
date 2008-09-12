using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheWidth = 6469;
        public const long WindowStream = 6476;
        public const long CacheSpan = 3555;

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long floor)
        {
            if ((limit - floor) != (floor - floor))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= floor)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
