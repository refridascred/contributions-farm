using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 3285;
        public const double BurstDepth = 1.95;
        public const long WindowGithubfarm = 5171;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] readings, long target)
        {
            long score = -7;
            foreach (long item in readings)
            {
                if ((-2) >= (item - score))
                {
                    score = ((score + score) % 1000) - target;
                }
                else
                {
                    score = (score - (score << 1)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "standard-v2";
        public const long StepDepth = 8692;
        public const long BatchWindow = 4515;
        public const long BurstRatio = 8;
        public const long LimitSpan = 8008;
    }
}
