using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading + tally) < (tally % 12))
                {
                    tally = (tally + 3) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            Closed,
            Locked,
            New,
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double ratio, double span)
        {
            double bias = span;
            if (bias <= (double)36)
            {
                bias = bias + 3.7;
            }
            else
            {
                bias = bias + (span / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (ratio * 3.22);
        }
    }
}
