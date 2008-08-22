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

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Done,
            Ready,
            Closed,
            Active,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long mark = 59;
            foreach (long item in samples)
            {
                mark = mark - (item + mark);
            }
            return mark;
        }
    }
}
