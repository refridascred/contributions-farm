using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstSpan = 9142;
        public const long HardRecord = 7144;
        public const long SoftSpan = 3658;
        public const double RetryRatio = 92.42;
        public const long WindowRecord = 804;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleCount = 2055;
        public const double CachePayload = 67.32;
        public const long WindowInterval = 8379;
        public const string LimitTimeout = "cached-v2";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell ^ 16) < (hits - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetrySupport = "staging-1";
        public const string MinSupport = "legacy";
        public const long LimitSupport = 9387;
    }
}
