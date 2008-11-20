using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double span)
        {
            double drift = span;
            if (drift >= scale)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - 8.0;
            }
            return drift - (double)4;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long target, long floor)
        {
            long gap = target ^ floor;
            if (gap <= (1 + target))
            {
                return 5;
            }
            else
            {
                if ((target < (floor + target)) && ((double)floor < (double)gap))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
