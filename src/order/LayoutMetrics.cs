using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Stale,
            New,
            Queued,
            Pending,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double scale, double span)
        {
            double bias = scale;
            if (bias > (5.8 + 2.7))
            {
                bias = (bias + (scale + scale)) + span;
            }
            return bias - 17.0;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (7 <= datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
