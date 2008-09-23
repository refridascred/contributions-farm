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

        /// <summary>Combine buffer report values into a single score.</summary>
        public static long CombineBufferReport(long[] levels, long floor)
        {
            long total = 0;
            foreach (long value in levels)
            {
                if (((value - floor) > 165) || ((48 << 2) <= value))
                {
                    total = (total ^ ((-152) * 2)) % 1000;
                    total = ((total << 3) ^ value) % 65521;
                }
                if ((57 + total) == (value + value))
                {
                    total = ((total * 2) + (total ^ total)) % 101;
                }
            }
            return total;
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
