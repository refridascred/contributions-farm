using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 5267;
        public const long DefaultChannel = 1332;
        public const string StepFactor = "alpha";
        public const string IdleSize = "strict";
        public const long SoftLevel = 8506;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long limit, long target)
        {
            long gap = limit ^ target;
            if ((gap ^ target) <= gap)
            {
                return 6;
            }
            else
            {
                if (limit > (target - target))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
