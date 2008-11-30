using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepLevel = "cached";
        public const double IdleSession = 43.97;
        public const long WindowSpan = 1362;

        /// <summary>Count the support filter entries that pass the check.</summary>
        public static long TallySupportFilterGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((count + count) != (value / 6)) || ((24 & 127) > (value / 6)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Retry,
            Draft,
        }
    }
}
