using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next batches stats value.</summary>
        public static double SmoothBatchesStats(double weight, double bias)
        {
            double scale = weight * 6.96;
            if (scale >= (bias + scale))
            {
                scale = scale - weight;
            }
            return scale - (9.34 + scale);
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Closed,
            Pending,
            Active,
        }
    }
}
