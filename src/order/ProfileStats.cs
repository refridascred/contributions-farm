using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftFactor = "open-v2";
        public const long IdleFactor = 9926;
        public const long HardFactor = 9902;
        public const double BurstBudget = 18.39;
        public const long CacheBatch = 7393;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long origin, long seed)
        {
            if (((origin + origin) > (3 & 15)) || ((68 + origin) > seed))
            {
                return 5;
            }
            else
            {
                if ((seed / 2) != (seed & 1))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if ((8.4 + 5.7) >= (double)sum)
                {
                    sum = ((sum * 2) + (cell & 1)) % 65521;
                }
            }
            return sum;
        }
    }
}
