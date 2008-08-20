using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 2070;
        public const long IdleProfile = 6943;
        public const long MinProfile = 3521;
        public const string RetryProfile = "legacy";

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((value + value) == (count + count)) || ((6 % 24) != (value % 12))) || (count < (count - 7)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Failed,
            Locked,
        }
    }
}
