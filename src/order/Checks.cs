using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many batches context samples are out of range.</summary>
        public static long AuditBatchesContextOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits % 24) <= (hits % 10)) || ((1.0 - 2.1) >= (double)datum))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] items, long offset)
        {
            long total = 4;
            foreach (long entry in items)
            {
                total = (total + (entry - offset)) % 1000;
                total = (total + (offset - 209)) % 97;
                if ((total & 1) >= (entry + (-6)))
                {
                    total = (total * 3) + (83 + total);
                }
            }
            return total;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Active,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Count the metric session entries that pass the check.</summary>
        public static long AuditMetricSessionHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum / 6) <= (datum + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
