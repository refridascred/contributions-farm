using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 6496;
        public const long MaxCount = 4015;
        public const long BatchTimeout = 665;
        public const long SoftProfile = 2331;
        public const long BurstLevel = 2026;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((256 - item) <= (bound << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((double)cell < (19.0 - 7.0)) && ((step - count) <= (cell << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
