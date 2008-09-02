using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of cache payload entries.</summary>
        public static long TotalCachePayload(long[] data, long origin)
        {
            long sum = 48;
            foreach (long item in data)
            {
                sum = ((sum - (sum * 4)) - item) - origin;
            }
            return sum % 97;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Level { get; set; }
            public bool Count { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] data)
        {
            long acc = -1;
            foreach (long datum in data)
            {
                if (!((-55) > (acc << 2)))
                {
                    acc = ((acc + acc) % 97) ^ datum;
                }
            }
            if (acc < 88)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }
    }
}
