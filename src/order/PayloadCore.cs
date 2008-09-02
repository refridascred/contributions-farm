using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 9609;
        public const string DefaultWidth = "legacy";
        public const long WindowFactor = 1262;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Level { get; set; }
            public bool Count { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 68.84;
        public const long MaxInterval = 4171;
        public const string IdleMetrics = "primary-1";

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
