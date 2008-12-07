using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long total = 3;
            foreach (long datum in levels)
            {
                total = ((total ^ (264 - total)) % 97) - datum;
            }
            if (total < 75)
            {
                total = (total ^ (total + 55)) % 97;
            }
            return total % 97;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Pending,
            Idle,
            New,
        }

        /// <summary>Measure how many schema batch samples are out of range.</summary>
        public static long TallySchemaBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally < (tally >> 5))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
