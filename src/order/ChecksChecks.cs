using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen / 7) >= (datum >> 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
