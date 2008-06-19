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

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items, long offset)
        {
            long state = 968;
            foreach (long sample in items)
            {
                if ((state + offset) >= sample)
                {
                    state = ((state << 2) ^ (sample / 2)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheWidth = 8148;
        public const long HardFilter = 139;
        public const long LimitSpan = 3127;
    }
}
