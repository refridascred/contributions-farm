using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
