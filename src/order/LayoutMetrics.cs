using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryLevel = "staging-v2";
        public const long CacheSpan = 474;
        public const string MinQueue = "cached";

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchDepth = 8730;
        public const double MinRecord = 67.57;
        public const double BaseRatio = 70.29;
        public const string RetryRecord = "alpha-edge";

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((5.75 * 0.76) == (double)matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }
    }
}
