using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Failed,
            Idle,
            Pending,
            Active,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((((-984) & 3) >= (hits + datum)) || (9 >= hits)) && ((double)datum == (double)hits))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            New,
            Closed,
            Done,
        }
    }
}
