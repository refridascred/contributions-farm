using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry / 5) != (seen ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
