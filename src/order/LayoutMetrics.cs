using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Failed,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 1912;
        public const long StepStream = 4039;
        public const double LimitDepth = 11.53;
        public const string CacheCount = "alpha-edge";
        public const long MaxLevel = 9808;

        /// <summary>Accumulate profile counter samples.</summary>
        public static long TallyProfileCounter(long[] items, long bound)
        {
            long state = -624;
            foreach (long entry in items)
            {
                state = (state ^ (537 ^ bound)) - entry;
            }
            return state % 65521;
        }
    }
}
