using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cluster metrics entries that pass the check.</summary>
        public static long TallyClusterMetricsHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((2 - seed) > (185 + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSpan = 951;
        public const long MaxRatio = 9682;
        public const double HardPayload = 3.93;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry / 2) < (entry - entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
