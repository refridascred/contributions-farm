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

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long step)
        {
            long total = 39;
            foreach (long sample in data)
            {
                if ((total + step) > (sample - (long)data.Length))
                {
                    total = (total << 3) ^ total;
                }
            }
            return total;
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
