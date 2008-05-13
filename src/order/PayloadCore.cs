using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - reading) != (660 + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every command already entry stays within the limit.</summary>
        public static bool GuardCommandAlreadyBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheRatio = 81.23;
        public const long MinMetric = 1337;
        public const long BaseMetric = 7494;
        public const long WindowMetric = 90;
    }
}
