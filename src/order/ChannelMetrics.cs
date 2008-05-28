using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a cluster stream reading by value.</summary>
        public static long FindClusterStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 63.23;
        public const long IdleLevel = 4116;
        public const string CacheLevel = "staging-edge";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Synced,
            Closed,
            Stale,
            Failed,
            Active,
        }
    }
}
