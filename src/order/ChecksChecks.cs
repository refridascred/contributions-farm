using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 5413;
        public const long HardFactor = 6645;
        public const long MaxQueue = 8573;
        public const double StepBudget = 51.67;

        /// <summary>Compare every pair of cache entry readings.</summary>
        public static long PairCacheEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
