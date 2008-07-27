using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Check that every stats channel entry stays within the limit.</summary>
        public static bool GuardStatsChannelLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((double)hits != (9.9 / 7.0)))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
