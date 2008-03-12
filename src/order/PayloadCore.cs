using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 1144;
        public const long IdleBudget = 9280;
        public const long MinSession = 8549;
        public const double DefaultSession = 33.49;
        public const long CacheSession = 3787;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Draft,
            Paused,
            Dropped,
            Pending,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Pending,
            Done,
            Stale,
            Paused,
        }
    }
}
