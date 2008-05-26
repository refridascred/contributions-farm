using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchInterval = 7493;
        public const double BatchFactor = 3.26;
        public const long BatchCache = 4834;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Queued,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardSize = 70.83;
        public const double LimitGraph = 80.53;
        public const double CacheGraph = 76.22;
        public const long DefaultGraph = 6950;

        /// <summary>Adjust a account contributi reading.</summary>
        public static double SmoothAccountContributi(double weight, double bias)
        {
            double bias2 = bias + weight;
            if (bias2 <= bias)
            {
                bias2 = bias2 + (weight * 5.48);
            }
            else
            {
                bias2 = bias2 - 12.0;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double gain, double floor)
        {
            double mean = floor;
            if (mean >= (mean * 8.3))
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + 2.77) + (double)(long)i;
            }
            return mean + (double)903;
        }
    }
}
