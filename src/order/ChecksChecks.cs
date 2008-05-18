using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit format route readings against a rule.</summary>
        public static long TallyFormatRouteOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits == (7.1 - 4.4))
                {
                    hits = ((hits + 2) + item) + origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Retry,
            Idle,
        }
    }
}
