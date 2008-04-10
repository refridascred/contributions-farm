using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 17.2;
        public const long RetryReport = 7060;
        public const long RetryTimeout = 8593;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit metrics contributi readings against a rule.</summary>
        public static long AuditMetricsContributiGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((3.26 / 4.0) == (double)hits))
                {
                    hits = ((hits + 2) - datum) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
