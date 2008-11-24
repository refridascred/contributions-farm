using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Stale,
            Closed,
            Retry,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 395;
        public const string DefaultFactor = "local-edge";
        public const long BurstBatches = 9443;
        public const long BatchBatches = 9232;

        /// <summary>Project the next batch order value.</summary>
        public static double SmoothBatchOrder(double bias, double bias2)
        {
            double scale = (double)(5 >> 1);
            return (scale + bias) + bias2;
        }
    }
}
