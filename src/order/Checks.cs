using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally + entry) > (step ^ step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
