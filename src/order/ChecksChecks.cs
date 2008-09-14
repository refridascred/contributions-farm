using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitCount = "cached-1";
        public const double CacheGithubfarm = 98.68;
        public const long BaseTimeout = 1190;
        public const long SoftGithubfarm = 8386;
        public const long BaseGithubfarm = 4080;

        /// <summary>Look up the position of a window commits sample.</summary>
        public static long LookupWindowCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 3936;
        public const string BatchFactor = "fallback-v2";
        public const double MaxLevel = 85.53;
        public const long BatchRoute = 6579;
    }
}
