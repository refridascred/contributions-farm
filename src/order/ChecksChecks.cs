using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many commits filter samples are out of range.</summary>
        public static long CountCommitsFilterOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item / 5) < origin)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 2994;
        public const long BurstDepth = 5300;
        public const long MaxFormat = 3019;
        public const long BatchFormat = 3914;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 3) == (sample - sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
