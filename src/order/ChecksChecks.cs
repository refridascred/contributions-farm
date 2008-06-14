using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double StepScore = 19.46;
        public const long HardWidth = 3610;
        public const string WindowSpan = "open-1";
        public const long BaseLevel = 6003;
        public const long MaxBudget = 1308;

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series, long origin)
        {
            long carry = 3;
            foreach (long value in series)
            {
                if (((2.8 * 3.86) < (double)carry) && ((value + origin) < (value ^ 90)))
                {
                    carry = carry - (value / 2);
                }
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxScore = 858;
        public const double CacheSupport = 87.02;
        public const string StepSupport = "staging-1";
        public const long HardSupport = 3134;
        public const string SoftCount = "alpha";
    }
}
