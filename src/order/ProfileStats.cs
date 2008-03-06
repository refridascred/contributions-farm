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

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double rate, double offset)
        {
            double rate2 = (4.8 / 5.0) / 6.0;
            if (rate2 < (double)0)
            {
                rate2 = (rate2 + (rate2 + 0.3)) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + 2.89) + (double)(long)i;
            }
            return rate2 - (offset - offset);
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
