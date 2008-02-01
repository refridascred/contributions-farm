using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 894;
        public const double BatchCount = 48.42;
        public const long MinGithubfarm = 791;
        public const long BurstGithubfarm = 3666;
        public const long BaseGithubfarm = 2730;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryWidth = 878;
        public const string MinWidth = "strict-1";
        public const double MaxSupport = 36.1;
        public const string SoftSupport = "primary-v2";
    }
}
