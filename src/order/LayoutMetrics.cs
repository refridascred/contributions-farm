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

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data)
        {
            long sum = 805;
            foreach (long reading in data)
            {
                sum = ((sum * 3) + (reading ^ sum)) % 4096;
            }
            if (sum > 6)
            {
                sum = ((sum * 4) + (sum - sum)) % 101;
            }
            return sum;
        }
    }
}
