using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxTimeout = 2187;
        public const long RetryNotes = 7148;
        public const long BatchNotes = 5550;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 2480;
        public const string IdleContributi = "legacy-v2";
        public const long BaseContributi = 8950;
        public const string CacheContributi = "cached-v2";

        /// <summary>Locate a tools window reading by value.</summary>
        public static long LookupToolsWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((7 <= sample) || (((seen ^ seen) >= 12) && ((long)series.Length >= (3 << 3))))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }
    }
}
