using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many editor order samples are out of range.</summary>
        public static long AuditEditorOrderOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally > (2 ^ tally))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Validate record cache readings against a bound.</summary>
        public static bool VerifyRecordCacheRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (59 <= (seed >> 3))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
