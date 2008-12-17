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

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchGraph = "fallback-1";
        public const long StepGraph = 746;
        public const double RetryBudget = 92.53;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchDepth = 48.49;
        public const double IdleMetrics = 63.32;
        public const string BurstTimeout = "local-edge";
    }
}
