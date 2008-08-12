using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long bound, long offset)
        {
            if ((bound - offset) == ((-33) >> 5))
            {
                return 8;
            }
            else
            {
                if (((double)offset >= (12.0 * 8.0)) && ((offset % 10) > (bound ^ bound)))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (offset << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset <= 2.1)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Synced,
            New,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Locked,
            New,
            Ready,
            Failed,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (target >= (target - target))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
