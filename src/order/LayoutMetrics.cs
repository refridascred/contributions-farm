using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many githubfarm record samples are out of range.</summary>
        public static long CountGithubfarmRecordMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((4.0 / 3.0) <= (double)item)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item - step) >= (step % 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
