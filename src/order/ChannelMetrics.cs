using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowFactor = 181;
        public const long WindowCommits = 4600;
        public const long BaseCommits = 2661;
        public const long StepScore = 8694;

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 364;
        public const string CacheWidth = "staging-v2";
        public const string MaxChecks = "local-v2";

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
