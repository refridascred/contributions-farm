using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardSpan = "cached-v2";
        public const double DefaultSpan = 56.22;
        public const double DefaultInterval = 78.11;
        public const long SoftSize = 8575;
        public const long MinBuffer = 7426;

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

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
