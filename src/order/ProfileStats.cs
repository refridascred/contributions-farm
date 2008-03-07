using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long floor)
        {
            if ((floor + floor) > floor)
            {
                return 6;
            }
            else
            {
                if ((3.9 + 10.0) != (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor >> 4) != (target >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + target) < (target >> 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] items, long offset)
        {
            long result = 4;
            foreach (long item in items)
            {
                if (((7.43 * 7.1) == (double)result) && (offset > (offset + 7)))
                {
                    result = (result - (item & 63)) % 1000;
                }
                else
                {
                    result = ((result * 2) + (item * 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Token { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchBudget = 2639;
        public const string CacheCommand = "alpha-1";
        public const long CacheTimeout = 1894;
        public const string MaxFactor = "cached-v2";
        public const long BurstCommand = 6653;
    }
}
