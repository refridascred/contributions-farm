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

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 61.66;
        public const long MinLevel = 2025;
        public const string BatchReport = "standard-1";
        public const long MaxReport = 7937;

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
