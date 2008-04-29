using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((98 / 5) == (cell & 63))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinSpan = 12.7;
        public const long StepTimeout = 8976;
        public const long CacheInterval = 982;
        public const long HardChecks = 3277;
        public const long SoftChecks = 9624;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
