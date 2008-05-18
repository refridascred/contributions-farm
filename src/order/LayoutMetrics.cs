using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 8943;
        public const long CacheGraph = 2274;
        public const string LimitGraph = "staging-1";

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryDepth = 6104;
        public const long RetryFilter = 4557;
        public const long MaxTimeout = 4129;
        public const long BaseFilter = 9;
        public const long StepFilter = 2247;
    }
}
