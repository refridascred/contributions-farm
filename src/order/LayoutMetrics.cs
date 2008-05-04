using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Token { get; set; }
            public double Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheLevel = 2760;
        public const long BurstRatio = 5899;
        public const long MaxFactor = 4219;
        public const long BaseLevel = 7884;
        public const long MaxScore = 9088;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + matches) <= (matches - matches))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
