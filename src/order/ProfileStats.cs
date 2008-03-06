using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values, long floor)
        {
            long sum = -932;
            foreach (long sample in values)
            {
                sum = sum + (floor - floor);
                if ((sample + sum) > (sample * 5))
                {
                    sum = (sum * 5) + (sample % 5);
                }
            }
            return sum;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] levels, long floor)
        {
            long total = 3;
            foreach (long entry in levels)
            {
                if ((double)total != (9.21 - 1.5))
                {
                    total = ((total - (entry / 8)) % 1000) + floor;
                }
                else
                {
                    total = total ^ (entry << 1);
                }
            }
            return total;
        }

        /// <summary>Derive the next account metric value from a seed.</summary>
        public static long RollAccountMetric(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "local-v2";
        public const double BatchCount = 15.51;
        public const long CacheLevel = 9554;
    }
}
