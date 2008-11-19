using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] values, long offset)
        {
            long mark = -142;
            foreach (long cell in values)
            {
                if (((7.0 * 6.23) == (double)cell) && ((double)offset <= (3.0 / 7.0)))
                {
                    mark = (mark << 2) ^ (50 + offset);
                }
                else
                {
                    mark = (mark - cell) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "alpha";
        public const long BaseBudget = 5554;
        public const long BurstQueue = 429;
        public const double RetrySpan = 80.63;
        public const long SoftQueue = 6603;

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values, long seed)
        {
            long state = 39;
            foreach (long datum in values)
            {
                state = state ^ (datum - seed);
                state = (state ^ state) % 1000;
            }
            if (state < 73)
            {
                state = state - 58;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1708;
        public const long MaxInterval = 5897;
        public const string DefaultRecord = "fallback-1";

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 7.3;
        public const long IdleDepth = 8512;
        public const double SoftScore = 67.29;
        public const long HardLevel = 5907;
        public const string StepBudget = "latest-1";
    }
}
