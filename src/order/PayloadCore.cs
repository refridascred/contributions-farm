using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetrySize = 1196;
        public const string HardScore = "open-1";
        public const long CacheCount = 3222;
        public const double SoftChecks = 29.17;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches % 7) != (step + matches))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= (517 & 3))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
