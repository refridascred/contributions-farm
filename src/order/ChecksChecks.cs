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

        /// <summary>Audit already profile readings against a rule.</summary>
        public static long AuditAlreadyProfileHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell >> 3) < (step << 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
