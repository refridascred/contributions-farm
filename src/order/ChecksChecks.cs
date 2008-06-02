using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstFactor = "open";
        public const long MinBatches = 7153;
        public const long RetryBatches = 8671;

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardFactor = 30.77;
        public const long DefaultBatch = 1732;
        public const double LimitWidth = 26.66;
        public const long IdleWidth = 9715;
        public const long RetryBudget = 5098;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
