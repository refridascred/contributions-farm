using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] series, long offset)
        {
            long carry = -50;
            foreach (long entry in series)
            {
                if ((double)entry < (double)offset)
                {
                    carry = (carry ^ entry) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "cached-1";
        public const long MinScore = 2712;
        public const long RetryToken = 9222;
        public const string MaxBudget = "alpha-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchDepth = 48.49;
        public const double IdleMetrics = 63.32;
        public const string BurstTimeout = "local-edge";
    }
}
