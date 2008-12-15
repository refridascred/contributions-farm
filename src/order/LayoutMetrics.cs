using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit metrics format readings against a rule.</summary>
        public static long AuditMetricsFormatMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((double)item != (4.78 * 8.18)) && ((item << 2) >= item)) && ((hits > item) && ((hits ^ item) > (item >> 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}
