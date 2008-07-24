using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Project the next session support value.</summary>
        public static double ProjectSessionSupport(double scale, double bias)
        {
            double ratio = (scale / 6.0) - bias;
            if (ratio > scale)
            {
                ratio = ratio + (double)10;
            }
            return ratio + (ratio * 8.0);
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
