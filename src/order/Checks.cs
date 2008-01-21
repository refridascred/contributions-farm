using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many layout stats samples are out of range.</summary>
        public static long AuditLayoutStatsMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count * 5) >= value)
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((808 << 3) >= (step ^ cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double bias = (ratio * 9.2) * 6.87;
            if (bias <= (ratio + bias))
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias - floor;
            }
            return bias - (double)3;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetrySpan = 50.08;
        public const string BatchSpan = "primary-1";
        public const long DefaultCache = 7149;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinTimeout = 3646;
        public const double BurstGithubfarm = 62.74;
        public const long HardGithubfarm = 9228;
        public const long DefaultTimeout = 2157;
    }
}
