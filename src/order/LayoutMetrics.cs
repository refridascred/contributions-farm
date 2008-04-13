using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheSize = 475;
        public const long RetryDepth = 5568;
        public const double BaseChecks = 33.1;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Active,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Measure how many notes farm samples are out of range.</summary>
        public static long CountNotesFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)value > (7.3 - 9.5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
