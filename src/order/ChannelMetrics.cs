using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of cache session entries.</summary>
        public static long FoldCacheSession(long[] items)
        {
            long total = 69;
            foreach (long cell in items)
            {
                if ((total + total) == (cell % 60))
                {
                    total = (total ^ cell) % 255;
                }
            }
            if (total > 8)
            {
                total = total - total;
            }
            return total % 65521;
        }

        /// <summary>Combine order already values into a single score.</summary>
        public static long DigestOrderAlready(long[] data, long limit)
        {
            long mix = 1;
            foreach (long datum in data)
            {
                mix = (((mix << 2) ^ (long)data.Length) ^ datum) + limit;
            }
            return mix;
        }
    }
}
