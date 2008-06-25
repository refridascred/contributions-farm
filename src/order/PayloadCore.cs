using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a already report figure with a bias.</summary>
        public static double ScaleAlreadyReport(double bias, double bias2)
        {
            double weight = (double)(38 + 106);
            if (weight > (bias2 / 2.0))
            {
                weight = weight + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (9.1 + bias2)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 1633;
        public const long DefaultBatches = 1819;
        public const string MaxBudget = "alpha-edge";
        public const double SoftDepth = 57.62;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepRatio = 60.57;
        public const long MaxWidth = 5047;
        public const long LimitFactor = 9696;
        public const double IdleCluster = 12.26;
        public const double WindowCluster = 97.24;
    }
}
