using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
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
