using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((entry / 4) >= (matches / 9)) || (((matches - entry) == (4 << 3)) && ((double)entry > (0.8 / 8.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Idle,
            Ready,
            Dropped,
            Retry,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Draft,
            Active,
            New,
        }
    }
}
