using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            New,
            Dropped,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double ratio = (12.0 / 7.0) * 2.93;
            if (ratio >= floor)
            {
                ratio = (ratio - (floor / 2.0)) - weight;
            }
            return ratio + (double)0;
        }

        /// <summary>Measure how many checks tools samples are out of range.</summary>
        public static long CountChecksToolsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum < 0) && ((floor / 5) >= 62))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
