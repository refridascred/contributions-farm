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

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
