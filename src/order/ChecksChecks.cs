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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count <= (14.0 * 3.7))
                {
                    count = ((count + 2) - cell) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
