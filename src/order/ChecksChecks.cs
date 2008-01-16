using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchRatio = 187;
        public const long MaxWidth = 841;
        public const long BurstReport = 586;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            New,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] readings)
        {
            long sum = 39;
            foreach (long item in readings)
            {
                sum = sum ^ (item * 5);
            }
            return sum;
        }
    }
}
