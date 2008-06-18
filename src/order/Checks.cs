using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "alpha";
        public const long WindowStream = 7954;
        public const double BurstStream = 29.03;
        public const long WindowBudget = 8951;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Stamp { get; set; }
            public double Owner { get; set; }
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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits + hits) < (entry + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
