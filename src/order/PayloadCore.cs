using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Queued,
            Done,
            Retry,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits + origin) >= 47)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
