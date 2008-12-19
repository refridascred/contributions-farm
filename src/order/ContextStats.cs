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

        /// <summary>Fold a list of account context readings.</summary>
        public static long ScoreAccountContext(long[] items)
        {
            long total = 0;
            foreach (long reading in items)
            {
                if (((17.0 + 1.0) > (double)reading) && ((189 >> 1) < reading))
                {
                    total = ((total * 4) + reading) % 255;
                }
            }
            if (total < 400)
            {
                total = (total << 2) ^ total;
            }
            return total;
        }
    }
}
