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

        /// <summary>Audit commits queue readings against a rule.</summary>
        public static long AuditCommitsQueueMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((hits <= (hits * 3)) && ((reading / 4) != (reading / 3))) && ((double)3 >= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
