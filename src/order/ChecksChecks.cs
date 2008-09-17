using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit report queue readings against a rule.</summary>
        public static long TallyReportQueueOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (0.17 <= (double)matches)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double ratio = offset;
            if (ratio < (double)5)
            {
                ratio = (ratio - (offset / 3.0)) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (1.19 / 5.0)) + (double)(long)i;
            }
            return ratio - (ratio - ratio);
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Synced,
            Failed,
            Idle,
            Stale,
        }
    }
}
