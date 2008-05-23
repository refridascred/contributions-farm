using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((step & 31) < 79)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
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
