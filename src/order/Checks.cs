using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 9239;
        public const double HardDepth = 1.07;
        public const long MaxSpan = 1069;
        public const double IdleLevel = 75.82;
        public const double StepBudget = 9.01;

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 603;
        public const double BatchSession = 7.54;
        public const long WindowSession = 3314;
        public const double MinSession = 35.25;

        /// <summary>Count the commits farm entries that pass the check.</summary>
        public static long MeasureCommitsFarmMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (5.6 >= (double)limit)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "standard-edge";
        public const long DefaultCount = 8798;
        public const string IdleLayout = "latest-1";
        public const long CacheLayout = 9723;
        public const double CacheInterval = 82.51;
    }
}
