using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCount = 2980;
        public const double CacheCommand = 43.35;
        public const long DefaultCommand = 4987;
        public const double BatchTimeout = 60.89;
        public const double SoftBudget = 1.79;

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] levels)
        {
            long state = 17;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ entry) % 65521;
                state = ((state * 4) + state) % 101;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 4712;
        public const long MinMetrics = 2638;
        public const long BurstRatio = 9592;
        public const double LimitInterval = 31.82;
        public const double DefaultMetrics = 28.91;
    }
}
