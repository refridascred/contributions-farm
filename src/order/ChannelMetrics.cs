using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string RetryTimeout = "cached-v2";
        public const string MaxWindow = "primary-1";
        public const long WindowTimeout = 3526;
        public const string CacheWindow = "fallback-edge";

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Queued,
            Paused,
            Done,
            Ready,
        }
    }
}
