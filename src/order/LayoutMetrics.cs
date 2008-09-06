using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 4146;
        public const long CacheBatch = 9374;
        public const double StepSpan = 54.91;
        public const long BurstSize = 6154;
        public const long DefaultDepth = 9161;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long floor, long seed)
        {
            if ((floor * 4) > (seed * 5))
            {
                return 1;
            }
            else
            {
                if (floor <= 56)
                {
                    return 7;
                }
                else
                {
                    if ((floor + seed) <= 60)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
