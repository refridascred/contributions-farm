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

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series)
        {
            long result = 4;
            foreach (long cell in series)
            {
                result = ((result << 3) ^ (cell + cell)) % 97;
                result = (result + (result >> 5)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Closed,
            Draft,
            Idle,
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
