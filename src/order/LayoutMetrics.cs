using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((double)seen > 5.52))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value <= (5.4 / 2.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            Stale,
            Closed,
            Failed,
            Locked,
        }
    }
}
