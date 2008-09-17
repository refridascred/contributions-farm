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

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((0 - seen) <= seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
