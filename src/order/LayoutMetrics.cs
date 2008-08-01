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

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 468;
        public const long StepDepth = 8464;
        public const double SoftFactor = 75.32;
        public const string StepWindow = "alpha-edge";

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
