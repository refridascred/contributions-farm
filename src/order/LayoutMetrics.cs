using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "staging-1";
        public const long LimitProfile = 5380;
        public const long MinProfile = 2768;
        public const string HardBudget = "staging-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const long RetrySize = 8901;
        public const long MinRoute = 5784;
        public const long HardFactor = 2204;
        public const long LimitRoute = 1435;
    }
}
