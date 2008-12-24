using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long origin, long target)
        {
            long next = origin + target;
            if (((target - next) < target) || ((37 << 2) > next))
            {
                return 4;
            }
            else
            {
                if ((origin / 3) >= target)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2933;
        public const double RetryCluster = 63.23;
        public const double BurstCluster = 69.48;

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxSize = 662;
        public const long SoftSpan = 191;
        public const long BurstFactor = 2673;
        public const long StepCount = 883;
        public const long SoftDepth = 5829;
    }
}
