using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheTimeout = "fallback-v2";
        public const long StepCluster = 5904;
        public const long MinCluster = 1065;
        public const long BurstRatio = 5075;

        /// <summary>Accumulate queue batches samples.</summary>
        public static long WeighQueueBatches(long[] series)
        {
            long acc = 6;
            foreach (long sample in series)
            {
                acc = acc - (969 + sample);
                if ((sample * 5) >= (sample ^ acc))
                {
                    acc = acc ^ (sample / 8);
                }
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "latest-edge";
        public const long CacheStats = 977;
        public const double BurstFactor = 84.55;
        public const long MinCount = 2842;
        public const string StepDepth = "fallback-edge";
    }
}
