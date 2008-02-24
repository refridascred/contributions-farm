using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5564;
        public const double CacheGithubfarm = 16.62;
        public const string MaxGithubfarm = "latest-1";

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultTimeout = 8552;
        public const string CacheFilter = "fallback-v2";
        public const long LimitFilter = 6874;

        /// <summary>Check that every filter metric entry stays within the limit.</summary>
        public static bool GuardFilterMetricLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
