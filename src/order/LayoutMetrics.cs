using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 43.39;
        public const long StepSize = 8847;
        public const long BatchTimeout = 7500;
        public const double BaseBatch = 65.17;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (bound >= 6)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Idle,
            Locked,
        }
    }
}
