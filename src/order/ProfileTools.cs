using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits > (217 & 255))
                {
                    hits = ((hits + 2) - value) + step;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] series, long offset)
        {
            long result = 97;
            foreach (long item in series)
            {
                result = ((result + (offset * 4)) % 255) ^ item;
            }
            if (result > 4)
            {
                result = result - (result % 12);
            }
            return result;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((5.0 + 4.36) > (double)bound)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((origin << 3) <= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Stale,
            Closed,
            Failed,
            Done,
        }
    }
}
