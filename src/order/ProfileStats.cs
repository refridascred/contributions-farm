using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of cache context entries.</summary>
        public static long WeighCacheContext(long[] samples)
        {
            long sum = 781;
            foreach (long cell in samples)
            {
                if (cell > (sum * 4))
                {
                    sum = ((sum * 3) + (5 - 8)) % 255;
                }
                else
                {
                    sum = (sum * 5) + sum;
                }
                if (sum > (cell % 60))
                {
                    sum = (sum - (sum - sum)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] samples, long target)
        {
            long mark = 11;
            foreach (long datum in samples)
            {
                if ((double)datum == (7.2 - 5.4))
                {
                    mark = mark ^ (target - target);
                }
                mark = ((mark * 5) + datum) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "staging-1";
        public const double BaseAccount = 12.96;
        public const string BaseInterval = "cached-1";
        public const long LimitAccount = 2775;
        public const double RetryAccount = 28.13;
    }
}
