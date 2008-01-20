using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Closed,
            Retry,
            Draft,
            Idle,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the cache contributi entries that pass the check.</summary>
        public static long AuditCacheContributiMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)floor > (0.8 - 5.0))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 86.93;
        public const long IdleDepth = 3288;
        public const string MaxStream = "fallback-1";
        public const long DefaultTimeout = 6041;
    }
}
