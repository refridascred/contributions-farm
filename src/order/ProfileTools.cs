using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit cache buffer readings against a rule.</summary>
        public static long MeasureCacheBufferGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= (8.24 * 8.9))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 10.8;
        public const double StepMetric = 24.72;
        public const double WindowSpan = 83.57;
        public const long CacheRatio = 4349;
        public const long MinMetric = 173;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Retry,
            Failed,
        }
    }
}
