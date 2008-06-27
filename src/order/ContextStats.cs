using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] values, long offset)
        {
            long acc = 9;
            foreach (long datum in values)
            {
                if ((datum - offset) != (acc & 7))
                {
                    acc = acc + (datum ^ acc);
                }
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 6151;
        public const string CacheContributi = "cached-v2";
        public const long BurstContributi = 1532;
        public const double LimitSize = 45.78;
        public const long WindowLevel = 6446;

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 79.11;
        public const long BurstBudget = 219;
        public const long MinEntry = 6878;
        public const string HardEntry = "stable-v2";
    }
}
