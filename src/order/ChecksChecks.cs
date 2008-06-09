using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Ready,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((bound % 24) == (reading - reading)) && ((593 + reading) > (bound / 8))) && ((double)reading > (5.0 * 2.8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a filter payload pair into a bucket.</summary>
        public static long SortFilterPayload(long origin, long target)
        {
            if ((13.0 * 9.29) >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((13.0 / 4.0) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
