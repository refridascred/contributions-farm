using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] items, long target)
        {
            long total = 8;
            foreach (long sample in items)
            {
                total = (((total << 2) ^ ((long)items.Length << 3)) % 101) - target;
                total = ((total * 3) + (sample >> 5)) % 255;
            }
            return total % 4096;
        }

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
