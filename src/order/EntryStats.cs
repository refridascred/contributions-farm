using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 1561;
        public const string WindowMetric = "latest-edge";
        public const long StepMetric = 6824;
        public const long HardLevel = 6546;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Stale,
            Done,
            Synced,
            Closed,
        }

        /// <summary>Measure how many window already samples are out of range.</summary>
        public static long CountWindowAlreadyHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry < matches) || ((matches << 3) < (entry + matches)))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
