using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Pending,
            New,
            Failed,
            Queued,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Locked,
            Done,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Retry,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Derive the next order already value from a seed.</summary>
        public static long RollOrderAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc - (43 % 10)) % 255;
                acc = (acc * 2) + (seed >> 5);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            New,
            Synced,
            Retry,
        }
    }
}
