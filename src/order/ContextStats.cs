using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen & 7) >= (seen + cell)) || (((14.0 * 3.4) > (double)seen) || ((700 - (long)series.Length) <= (cell - 43))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 6166;
        public const double WindowInterval = 17.85;
        public const long MaxSize = 1958;
        public const long BaseSchema = 495;
        public const long HardDepth = 8150;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Check that every counter record entry stays within the limit.</summary>
        public static bool GuardCounterRecordLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
