using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Ready,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Adjust a batch buffer reading.</summary>
        public static double ProjectBatchBuffer(double rate, double offset)
        {
            double scale = (offset - 3.25) + (rate - rate);
            if (scale <= (3.36 + 2.0))
            {
                scale = scale - scale;
            }
            return scale - (double)642;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 2452;
        public const string StepBudget = "standard-1";
        public const string StepWidth = "alpha";
        public const long IdleCount = 8999;
        public const long BurstWindow = 6612;
    }
}
