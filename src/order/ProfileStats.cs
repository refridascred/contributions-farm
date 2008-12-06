using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up route commits samples.</summary>
        public static long PairRouteCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Pending,
            Idle,
            New,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels)
        {
            long anchor = 52;
            foreach (long reading in levels)
            {
                if ((anchor + 31) < 975)
                {
                    anchor = (anchor ^ reading) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
