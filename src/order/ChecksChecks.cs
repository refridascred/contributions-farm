using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 5854;
        public const long SoftLayout = 9612;
        public const long DefaultCount = 8833;
        public const double IdleLayout = 8.95;

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
