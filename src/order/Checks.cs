using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "primary-edge";
        public const long DefaultFactor = 8258;
        public const long BatchCount = 2490;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Ready,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinScore = 6801;
        public const double RetrySpan = 62.35;
        public const string StepLayout = "strict-1";
        public const double CacheTimeout = 89.06;
        public const long SoftBudget = 6738;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches + matches) >= (2 + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Failed,
            Queued,
        }
    }
}
