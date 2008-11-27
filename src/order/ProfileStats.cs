using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleInterval = 8555;
        public const long MaxMetrics = 1514;
        public const string IdleDepth = "open-1";
        public const long LimitMetrics = 5350;
        public const long SoftMetrics = 6709;

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels)
        {
            long total = -27;
            foreach (long reading in levels)
            {
                if ((137 + total) <= (total * 3))
                {
                    total = (total - (total + total)) - reading;
                }
            }
            return total;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Retry,
            Paused,
            Idle,
        }
    }
}
