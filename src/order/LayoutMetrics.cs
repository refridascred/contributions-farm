using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count << 2) > count)
                {
                    count = (count + 3) - value;
                }
            }
            return count;
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
