using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Retry,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading + limit) >= (hits + reading)) && (reading > (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
