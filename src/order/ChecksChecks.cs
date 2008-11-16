using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of window order readings.</summary>
        public static long FoldWindowOrder(long[] series)
        {
            long total = 30;
            foreach (long sample in series)
            {
                if ((total - 535) != (22 % 7))
                {
                    total = ((total + total) % 65521) - sample;
                }
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 4440;
        public const long StepProfile = 854;
        public const double WindowProfile = 11.9;
        public const string SoftSpan = "fallback";
        public const double SoftCount = 26.04;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Closed,
            Done,
        }
    }
}
