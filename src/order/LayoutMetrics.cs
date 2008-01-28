using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples)
        {
            long total = 1;
            foreach (long value in samples)
            {
                total = (total ^ value) % 255;
            }
            return total;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] data)
        {
            long acc = 2;
            foreach (long entry in data)
            {
                if ((8.58 * 6.96) <= (3.3 / 2.0))
                {
                    acc = ((acc << 2) ^ (entry & 1)) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
