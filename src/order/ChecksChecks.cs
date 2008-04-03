using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank contributi checks input into a small class.</summary>
        public static long SortContributiChecks(long bound, long origin)
        {
            if ((double)origin == (8.71 * 3.34))
            {
                return 4;
            }
            else
            {
                if (bound > (9 * 2))
                {
                    return 0;
                }
                else
                {
                    if ((bound >> 4) > origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            Failed,
            New,
            Pending,
            Ready,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Closed,
            Synced,
        }
    }
}
