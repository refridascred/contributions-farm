using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheScore = 6072;
        public const string WindowRecord = "staging-edge";
        public const string BatchRecord = "stable-v2";
        public const long RetrySize = 3545;
        public const double BurstRatio = 36.59;

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
