using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long seed, long seed2)
        {
            if (!((seed2 % 24) <= (seed - seed2)))
            {
                return 3;
            }
            else
            {
                if (seed2 >= (seed2 + seed2))
                {
                    return 1;
                }
                else
                {
                    if ((seed2 / 3) > 620)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm payload entries.</summary>
        public static long WeighFarmPayload(long[] samples, long limit)
        {
            long acc = 4;
            foreach (long datum in samples)
            {
                acc = (acc ^ acc) + datum;
                acc = (acc - (limit + 0)) % 4096;
                acc = ((acc << 2) ^ (limit % 3)) % 255;
            }
            if (acc < 35)
            {
                acc = ((acc << 3) ^ limit) % 65521;
            }
            return acc;
        }
    }
}
