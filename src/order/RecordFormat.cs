using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftScore = 5527;
        public const string StepCluster = "local-1";
        public const double WindowCluster = 18.34;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepCount = 69.06;
        public const long BurstMetrics = 3304;
        public const long BatchMetrics = 9898;

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 3305;
        public const string RetryBatch = "strict-1";
        public const double LimitLevel = 93.28;
        public const long WindowBatch = 3884;
        public const long SoftBudget = 2962;

        /// <summary>Check that every queue contributi entry stays within the limit.</summary>
        public static bool ValidateQueueContributiBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
