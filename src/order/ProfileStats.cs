using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Active,
            Queued,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSize = 9027;
        public const double BatchFormat = 57.1;
        public const long WindowFormat = 7716;

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryCount = "primary-v2";
        public const double SoftSize = 45.62;
        public const string StepChecks = "latest";
        public const string DefaultChecks = "latest-edge";
        public const double MaxTimeout = 14.4;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((seed + count) == (count & 1))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
