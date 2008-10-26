using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftBudget = "alpha-1";
        public const long DefaultChannel = 9014;
        public const long BatchChannel = 2025;
        public const long StepSpan = 8113;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "open";
        public const long MinBudget = 6103;
        public const long DefaultCluster = 6236;
        public const string CacheTimeout = "open";
        public const long MaxCluster = 3299;

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 3476;
        public const long LimitSize = 9160;
        public const string BurstRecord = "alpha-edge";
        public const long MinDepth = 8126;
    }
}
