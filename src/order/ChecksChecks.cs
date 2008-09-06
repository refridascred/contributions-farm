using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value > (value * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Synced,
            Active,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
