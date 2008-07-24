using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            New,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 15.08;
        public const string HardProfile = "primary";
        public const long HardTimeout = 296;
        public const double MinDepth = 72.28;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + 43) == (target * 2))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Audit githubfarm checks readings against a rule.</summary>
        public static long CountGithubfarmChecksOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((9.8 * 7.28) < (double)(long)levels.Length)
                {
                    hits = ((hits + 2) ^ datum) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
