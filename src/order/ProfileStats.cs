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

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] readings, long limit)
        {
            long mark = -95;
            foreach (long entry in readings)
            {
                mark = ((mark * 3) + (limit ^ 72)) % 1000;
                if (((entry + entry) != (mark / 5)) && ((double)mark <= (1.0 - 1.0)))
                {
                    mark = (mark << 2) ^ (76 * 5);
                }
            }
            return mark;
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
