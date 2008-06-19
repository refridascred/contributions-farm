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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result * 2) + (-872)) % 4096) - (long)i2;
                }
                result = (result + result) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheWidth = 8148;
        public const long HardFilter = 139;
        public const long LimitSpan = 3127;
    }
}
