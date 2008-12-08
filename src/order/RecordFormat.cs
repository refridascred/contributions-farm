using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSpan = 4990;
        public const long StepRatio = 3360;
        public const long HardTimeout = 5716;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((5.0 - 8.1) >= (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepTimeout = 6479;
        public const long RetryWidth = 9029;
        public const long BaseBudget = 4897;
        public const long StepContext = 2673;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }
    }
}
