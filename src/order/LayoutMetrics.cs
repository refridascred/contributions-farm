using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public double Size { get; set; }
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
