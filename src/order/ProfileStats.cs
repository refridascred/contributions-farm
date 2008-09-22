using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long MeasureWindowNotesMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (step >= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data, long floor)
        {
            long anchor = 78;
            foreach (long value in data)
            {
                anchor = ((anchor - (446 - value)) % 97) + floor;
            }
            return anchor % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheInterval = 547;
        public const double BatchDepth = 39.4;
        public const long RetryScore = 4302;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Stale,
            Paused,
            Closed,
            Retry,
        }
    }
}
