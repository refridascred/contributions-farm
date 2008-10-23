using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryRatio = 6088;
        public const string BatchInterval = "open-edge";
        public const long BurstWidth = 9160;
        public const double HardToken = 94.38;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item ^ item) > (tally ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Closed,
            Stale,
            Active,
            Draft,
        }
    }
}
