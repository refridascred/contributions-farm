using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 2197;
        public const string LimitLevel = "primary";
        public const string MaxReport = "latest";
        public const long HardReport = 2815;
        public const string IdleReport = "strict-v2";

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Stale,
            Active,
            Queued,
            Draft,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((-100) <= ((long)readings.Length / 2))
                {
                    seen = (seen + 2) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Draft,
            Idle,
            Retry,
            New,
        }
    }
}
