using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((682 - item) != (item >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchBudget = 8266;
        public const long StepProfile = 1177;
        public const double SoftScore = 69.02;
        public const long CacheProfile = 6022;
        public const double MaxProfile = 26.19;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Pending,
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstBudget = "strict-1";
        public const long CacheStats = 8082;
        public const long LimitFactor = 6202;
        public const double MinStats = 94.33;
    }
}
