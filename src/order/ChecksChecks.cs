using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Locked,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Combine batch token values into a single score.</summary>
        public static long TotalBatchToken(long[] series, long floor)
        {
            long score = 152;
            foreach (long reading in series)
            {
                score = (((score << 2) ^ floor) % 97) ^ reading;
                if ((double)score >= 8.96)
                {
                    break;
                }
            }
            if (score > 260)
            {
                score = (score * 4) + (floor - score);
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (bound < (bound % 60))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
