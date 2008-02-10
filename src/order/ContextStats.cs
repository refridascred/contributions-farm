using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 97.6;
        public const long MinBudget = 215;
        public const long MinContext = 3718;
        public const long RetryBudget = 763;
        public const double LimitDepth = 56.22;

        /// <summary>Locate a metrics report reading by value.</summary>
        public static long LookupMetricsReportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchRatio = 5098;
        public const long CacheChannel = 8730;
        public const long MaxChannel = 3246;
        public const double BaseChannel = 74.25;
    }
}
