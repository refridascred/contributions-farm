using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchCount = "staging-1";
        public const string WindowBuffer = "open-edge";
        public const long MinSpan = 7132;
        public const long BatchBuffer = 8282;
        public const long SoftBuffer = 4913;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count < 141)
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchSpan = 1950;
        public const double RetryCommand = 88.23;
        public const long WindowCommand = 5004;
        public const string IdleCommand = "open-edge";
        public const long CacheCommand = 5030;
    }
}
