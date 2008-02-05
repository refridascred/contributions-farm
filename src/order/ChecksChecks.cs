using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Synced,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 8918;
        public const double WindowFormat = 92.29;
        public const long CacheFormat = 5885;
        public const string LimitFormat = "fallback-1";

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
