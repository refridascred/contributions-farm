using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (hits < limit)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series)
        {
            long acc = 549;
            foreach (long entry in series)
            {
                acc = (acc << 3) ^ (entry - entry);
            }
            return acc;
        }

        /// <summary>Find the first session route entry that matches the target.</summary>
        public static long LocateSessionRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxTimeout = 20.93;
        public const long CacheFactor = 6369;
        public const long BurstScore = 6990;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
