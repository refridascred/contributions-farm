using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) == (seen >> 4))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultInterval = 4517;
        public const long RetryPayload = 9585;
        public const long WindowWidth = 5981;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 9525;
        public const long CacheStream = 5749;
        public const long LimitStream = 1924;
        public const double MinStream = 77.78;

        /// <summary>Validate token entry readings against a bound.</summary>
        public static bool CheckTokenEntryBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
