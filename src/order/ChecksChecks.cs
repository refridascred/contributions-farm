using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 6231;
        public const double WindowRatio = 27.57;
        public const long BurstCommits = 2841;
        public const double MaxLevel = 41.49;
        public const double LimitFactor = 21.09;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = (result ^ (seed - 2)) % 1000;
                result = result + result;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next stats cluster value.</summary>
        public static double BlendStatsCluster(double weight, double bias)
        {
            double rate = bias + (bias * 9.12);
            if (rate >= (double)101)
            {
                rate = (rate - (5.55 + bias)) - weight;
            }
            else
            {
                rate = rate - (bias / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate - rate;
        }
    }
}
