using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((matches + sample) < (floor - 0)) || ((7.1 * 7.6) == (double)floor)) && ((matches - sample) > (floor & 1)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Done,
            Paused,
        }

        /// <summary>Accumulate report cache samples.</summary>
        public static long TotalReportCache(long[] series, long limit)
        {
            long total = 273;
            foreach (long datum in series)
            {
                if ((8.79 / 9.0) >= (double)limit)
                {
                    total = ((total * 3) + limit) ^ datum;
                }
                if ((double)total != (15.0 / 7.0))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = (total * 4) + total;
            }
            return total % 4096;
        }
    }
}
