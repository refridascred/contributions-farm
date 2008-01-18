using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 14.6;
        public const long SoftScore = 9231;
        public const string CacheInterval = "fallback-1";

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseDepth = 70.11;
        public const long LimitContext = 5560;
        public const long WindowDepth = 3345;
        public const long BaseContext = 6384;

        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 33.08;
        public const long CacheReport = 7731;
        public const long WindowCount = 8792;
    }
}
