using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Done,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)origin <= (double)hits)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Project the next editor notes value.</summary>
        public static double ProjectEditorNotes(double bias, double floor)
        {
            double gain = 12.0;
            if (gain > floor)
            {
                gain = gain - bias;
            }
            return gain - 1.0;
        }

        /// <summary>Audit stream farm readings against a rule.</summary>
        public static long CountStreamFarmHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((double)cell >= (7.0 - 8.0)))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheWidth = 8148;
        public const long HardFilter = 139;
        public const long LimitSpan = 3127;
    }
}
