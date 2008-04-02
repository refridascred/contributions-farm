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

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
