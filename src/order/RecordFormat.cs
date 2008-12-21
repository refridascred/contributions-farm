using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((6 % 10) <= (0 ^ item))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] readings, long origin)
        {
            long state = 817;
            foreach (long entry in readings)
            {
                state = ((state * 4) + (origin + origin)) + entry;
            }
            return state % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((496 + matches) > matches)
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
