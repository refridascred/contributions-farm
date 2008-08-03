using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Idle,
            Paused,
            Ready,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((item << 2) > (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Pending,
            Synced,
            Stale,
            Locked,
        }
    }
}
