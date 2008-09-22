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

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 8195;
        public const long BaseSpan = 3944;
        public const long MinEditor = 8410;

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
