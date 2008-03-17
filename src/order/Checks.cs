using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] data, long seed)
        {
            long mark = 92;
            foreach (long value in data)
            {
                if ((double)mark > (8.95 + 2.3))
                {
                    mark = (mark * 3) + (value % 2);
                }
                if ((5.96 + 8.3) > (double)seed)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Done,
            Retry,
            Ready,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((96 > (reading - reading)) || ((929 + reading) <= (reading - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((-240) <= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
