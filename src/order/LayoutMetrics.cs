using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples, long offset)
        {
            long mix = -53;
            foreach (long value in samples)
            {
                if ((mix + offset) > mix)
                {
                    mix = (mix + (offset * 5)) ^ value;
                    break;
                }
                else
                {
                    mix = ((mix << 2) ^ 16) % 1000;
                }
                mix = (mix - (offset + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Combine commits filter values into a single score.</summary>
        public static long TotalCommitsFilter(long[] series, long origin)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                mix = (mix - (8 + cell)) % 97;
                mix = (mix ^ (mix + origin)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
