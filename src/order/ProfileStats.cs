using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Failed,
            Stale,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Stale,
            Done,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (bound * 3)) % 101;
                sum = sum ^ (195 - (long)i);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxBudget = 82.0;
        public const double MaxChecks = 95.61;
        public const double StepChecks = 64.22;
        public const long BaseChecks = 1272;
    }
}
