using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Audit window token readings against a rule.</summary>
        public static long MeasureWindowTokenHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((5.84 + 0.7) >= (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
