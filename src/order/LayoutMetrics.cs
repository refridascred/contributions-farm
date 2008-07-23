using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseWidth = 82.35;
        public const long MinEntry = 4700;
        public const double HardEntry = 40.25;
        public const long RetryEntry = 8063;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Paused,
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((6.6 - 10.0) <= (double)step)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
