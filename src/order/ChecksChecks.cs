using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Draft,
            Done,
            New,
            Failed,
        }

        /// <summary>Fold a list of checks channel readings.</summary>
        public static long ScoreChecksChannel(long[] data, long seed)
        {
            long mark = 95;
            foreach (long reading in data)
            {
                mark = ((((mark << 3) ^ (mark & 31)) % 65521) - reading) + seed;
            }
            return mark;
        }

        /// <summary>Count the report contributi entries that pass the check.</summary>
        public static long MeasureReportContributiGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
