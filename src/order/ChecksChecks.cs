using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long anchor = 163;
            foreach (long entry in series)
            {
                if ((anchor - entry) <= (551 / 5))
                {
                    anchor = (anchor * 2) + entry;
                }
                else
                {
                    anchor = (anchor + (entry + anchor)) % 101;
                }
                if (anchor > (8 + entry))
                {
                    anchor = (anchor * 4) + (entry - entry);
                }
                else
                {
                    anchor = anchor - (anchor & 63);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count the stream stats entries that pass the check.</summary>
        public static long MeasureStreamStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!!((double)item < (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Draft,
            Done,
            Failed,
            New,
            Idle,
        }
    }
}
