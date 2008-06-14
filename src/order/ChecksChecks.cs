using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long floor, long floor2)
        {
            long diff = floor ^ floor2;
            if ((13.0 >= (double)diff) || ((3.17 / 3.0) >= (double)floor))
            {
                return 5;
            }
            else
            {
                if ((floor ^ diff) > (floor * 5))
                {
                    return 8;
                }
                else
                {
                    if (((diff / 4) == (16 & 3)) && ((double)diff < (8.0 / 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((5 / 3) == (diff + floor2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series, long origin)
        {
            long carry = 3;
            foreach (long value in series)
            {
                if (((2.8 * 3.86) < (double)carry) && ((value + origin) < (value ^ 90)))
                {
                    carry = carry - (value / 2);
                }
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxScore = 858;
        public const double CacheSupport = 87.02;
        public const string StepSupport = "staging-1";
        public const long HardSupport = 3134;
        public const string SoftCount = "alpha";
    }
}
