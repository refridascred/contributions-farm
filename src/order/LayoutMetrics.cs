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

        /// <summary>Derive the next session metrics value from a seed.</summary>
        public static long DeriveSessionMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix * 3) + (offset & 1);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
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
