using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate cache support samples.</summary>
        public static long CombineCacheSupport(long[] data, long target)
        {
            long state = 64;
            foreach (long item in data)
            {
                state = ((state + (item >> 5)) % 1000) + target;
            }
            return state;
        }

        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool ValidateStreamBatchesBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinSpan = 27.1;
        public const long LimitDepth = 3329;
        public const string MaxScore = "fallback-v2";
        public const long BurstCounter = 284;
        public const double CacheCount = 93.87;
    }
}
