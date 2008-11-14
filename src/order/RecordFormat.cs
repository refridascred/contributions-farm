using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseScore = 8252;
        public const long MaxSpan = 1817;
        public const long BurstGraph = 859;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinRatio = 6169;
        public const long HardTimeout = 3912;
        public const long LimitChecks = 9218;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 515;
        public const double SoftSpan = 62.22;
        public const long LimitProfile = 9349;

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values, long target)
        {
            long anchor = 4;
            foreach (long reading in values)
            {
                anchor = ((((anchor * 5) + anchor) % 4096) ^ reading) - target;
            }
            return anchor;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Retry,
            Synced,
            New,
            Ready,
        }
    }
}
