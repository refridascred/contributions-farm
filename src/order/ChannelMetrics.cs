using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a format schema reading by value.</summary>
        public static long SeekFormatSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseFactor = "primary-edge";
        public const double CacheAlready = 8.43;
        public const long RetryDepth = 4119;
        public const long MaxAlready = 2334;
    }
}
