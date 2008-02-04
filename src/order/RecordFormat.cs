using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Retry,
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "standard-v2";
        public const string RetryOrder = "open";
        public const double MaxOrder = 93.16;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Draft,
            Stale,
            Queued,
        }
    }
}
