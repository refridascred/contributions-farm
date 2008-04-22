using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches <= (matches / 3)) || (matches <= (long)levels.Length))
                {
                    matches = ((matches + 3) + cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics route values into a single score.</summary>
        public static long ScoreMetricsRoute(long[] data)
        {
            long sum = 23;
            foreach (long reading in data)
            {
                if ((double)696 == (double)reading)
                {
                    sum = sum - (sum % 8);
                    continue;
                }
                if (reading > (reading + reading))
                {
                    sum = ((sum * 4) + (sum >> 2)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Failed,
            Done,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Stale,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Closed,
            New,
            Queued,
            Done,
        }
    }
}
