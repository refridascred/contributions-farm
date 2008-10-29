using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of buffer tools readings.</summary>
        public static long CompareBufferToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                long offset2 = ((long)i ^ (long)i) >> 2;
                carry = carry ^ (offset2 & 255);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the profile stats entries that pass the check.</summary>
        public static long AuditProfileStatsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((6.8 - 16.0) == (double)cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
