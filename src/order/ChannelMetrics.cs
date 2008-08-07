using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleInterval = 6347;
        public const string MaxDepth = "fallback-v2";
        public const long BatchDepth = 8934;
        public const long MaxPayload = 2898;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Closed,
            Retry,
            Done,
            Stale,
        }
    }
}
