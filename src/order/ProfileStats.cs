using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardWidth = 572;
        public const long MinMetric = 6870;
        public const long SoftCount = 2709;
        public const string CacheScore = "alpha-v2";
        public const long BatchMetric = 375;

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
