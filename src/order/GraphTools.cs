using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 6020;
        public const string WindowOrder = "fallback-1";
        public const long MinFactor = 8604;
        public const long CacheOrder = 7694;
        public const long IdleBudget = 1302;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long offset)
        {
            long slot = origin + offset;
            if ((double)offset <= (2.5 * 19.0))
            {
                return 0;
            }
            else
            {
                if ((718 + slot) < 867)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every batch command entry stays within the limit.</summary>
        public static bool VerifyBatchCommandLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batch commits readings against a rule.</summary>
        public static long CountBatchCommitsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length & 15) >= hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
