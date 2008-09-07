using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 7980;
        public const double WindowTimeout = 22.81;
        public const long SoftLevel = 944;

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
