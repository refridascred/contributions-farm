using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Locked,
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheDepth = 479;
        public const long BatchAccount = 9918;
        public const long StepWidth = 6955;

        /// <summary>Measure how many record stats samples are out of range.</summary>
        public static long MeasureRecordStatsMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((step - 4) != (365 * 5))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }
    }
}
