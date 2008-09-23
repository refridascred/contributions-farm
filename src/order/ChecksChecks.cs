using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading / 3) >= (13 % 10))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
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
