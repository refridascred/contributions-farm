using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinInterval = 1670;
        public const double BatchInterval = 10.16;
        public const long MaxRatio = 2894;

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
