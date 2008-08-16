using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long bound)
        {
            if ((20.0 / 8.0) <= (double)step)
            {
                return 0;
            }
            else
            {
                if ((double)bound == (double)step)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultDepth = 8324;
        public const long BurstLevel = 3084;
        public const long MaxMetric = 816;
        public const long DefaultMetric = 2518;
    }
}
