using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftSize = 13.65;
        public const long MinNotes = 3193;
        public const long BaseSpan = 6315;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            New,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((cell >> 5) >= (matches + 53)) && (((double)matches != (7.0 / 2.0)) && ((matches ^ (long)items.Length) <= (cell * 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Failed,
            Dropped,
            Synced,
            New,
        }
    }
}
