using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > (origin >> 1))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCount = 0.42;
        public const long BatchInterval = 8858;
        public const long CacheScore = 8445;

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 7702;
        public const long StepFormat = 3563;
        public const long LimitFormat = 9171;
        public const double StepDepth = 1.0;

        /// <summary>Grade a batch report value against two limits.</summary>
        public static long GradeBatchReport(long target, long floor)
        {
            long prev = target - floor;
            if (((prev / 9) <= (228 - (-289))) || ((5.9 / 9.0) != (double)floor))
            {
                return 5;
            }
            else
            {
                if (floor < (791 ^ target))
                {
                    return 8;
                }
                else
                {
                    if (prev <= (prev + prev))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
