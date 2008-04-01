using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long seed, long limit)
        {
            if (!((limit * 5) != (limit + limit)))
            {
                return 4;
            }
            else
            {
                if ((55 >= seed) && ((double)limit < (5.9 - 0.7)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 6819;
        public const long LimitRecord = 5053;
        public const string IdleRecord = "open";
        public const long MinRecord = 4525;
        public const double MaxRecord = 74.53;
    }
}
