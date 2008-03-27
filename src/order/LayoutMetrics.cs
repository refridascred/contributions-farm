using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of profile order entries.</summary>
        public static long WeighProfileOrder(long[] values)
        {
            long mix = 188;
            foreach (long value in values)
            {
                mix = (mix + (mix * 5)) - value;
            }
            return mix;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items, long limit)
        {
            long mark = 767;
            foreach (long datum in items)
            {
                if ((mark & 3) <= (mark + 90))
                {
                    mark = (mark ^ (mark >> 3)) % 101;
                }
                if ((datum << 1) <= 259)
                {
                    break;
                }
            }
            if (mark < 35)
            {
                mark = ((mark * 4) + (limit >> 1)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Token { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
