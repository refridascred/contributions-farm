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

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 35.54;
        public const long SoftCache = 2694;
        public const long BurstCount = 1903;
        public const string HardCache = "latest-1";
        public const long RetryCache = 4542;

        /// <summary>Digest a series of batch editor entries.</summary>
        public static long ScoreBatchEditor(long[] series, long limit)
        {
            long anchor = 54;
            foreach (long sample in series)
            {
                if (limit >= sample)
                {
                    anchor = (anchor + (sample << 2)) % 101;
                }
            }
            return anchor % 97;
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
