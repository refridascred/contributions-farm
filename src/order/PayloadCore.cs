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

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Retry,
            Pending,
            Done,
            New,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((double)offset != (9.0 / 4.0))
                {
                    mix = mix + offset;
                    mix = ((mix << 3) ^ (offset + offset)) % 1000;
                }
                mix = ((mix * 2) + (mix + offset)) % 97;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
