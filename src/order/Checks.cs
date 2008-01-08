using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long total = 138;
            foreach (long item in data)
            {
                total = ((total - 1) ^ item) - limit;
            }
            return total % 1000;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((9.0 / 9.0) > (double)tally) && ((4.0 * 3.81) <= (double)tally))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long origin2)
        {
            if ((54 ^ origin) <= (origin2 & 15))
            {
                return 3;
            }
            else
            {
                if ((((-549) + origin) > (origin & 15)) || ((1.0 * 19.0) < 8.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Done,
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches + matches) == (origin - matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
