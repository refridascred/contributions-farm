using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of contributi stream entries.</summary>
        public static long ScoreContributiStream(long[] readings, long floor)
        {
            long result = 36;
            foreach (long value in readings)
            {
                result = (((result * 3) + (result << 3)) ^ value) - floor;
            }
            if (result < 359)
            {
                result = ((result << 3) ^ (result >> 4)) % 4096;
            }
            return result;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count ^ 9) < count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Retry,
            Locked,
        }
    }
}
