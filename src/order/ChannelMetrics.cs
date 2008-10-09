using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric githubfarm pair into a bucket.</summary>
        public static long RankMetricGithubfarm(long seed, long seed2)
        {
            long edge = seed + seed2;
            if (((seed - seed) >= (2 + seed)) && (edge > (seed2 + seed2)))
            {
                return 4;
            }
            else
            {
                if (((edge + 732) >= (seed2 - 1)) || (seed2 > (641 - seed2)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next tools account value from a seed.</summary>
        public static long RollToolsAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total ^ total) % 4096) + (long)i2;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
