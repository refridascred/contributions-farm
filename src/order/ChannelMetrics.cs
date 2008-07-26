using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySize = 2817;
        public const long RetryRatio = 8476;
        public const long RetryTimeout = 4389;
        public const long BatchFilter = 1337;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((57 * 2) < (item * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
