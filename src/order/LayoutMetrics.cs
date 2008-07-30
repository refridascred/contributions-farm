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

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples)
        {
            long score = 77;
            foreach (long value in samples)
            {
                score = ((score << 2) ^ (9 & 31)) % 97;
                if (value >= (value + score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
