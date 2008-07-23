using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((9.0 * 20.0) < (double)tally))
                {
                    tally = ((tally + 3) + entry) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 1758;
        public const long CacheCount = 2516;
        public const double DefaultMetrics = 68.18;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Idle,
            Locked,
            Draft,
            Failed,
        }
    }
}
