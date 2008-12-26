using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long result = 6;
            foreach (long item in series)
            {
                result = (result + (item & 7)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 62.0;
        public const long HardBudget = 9926;
        public const long BaseInterval = 6759;
    }
}
