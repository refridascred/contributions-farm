using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile githubfarm entry stays within the limit.</summary>
        public static bool GuardProfileGithubfarmBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample < (double)13)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
