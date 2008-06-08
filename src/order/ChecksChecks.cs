using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the profile token entries that pass the check.</summary>
        public static long TallyProfileTokenHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (target < (821 << 3))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout format samples.</summary>
        public static long TallyLayoutFormat(long[] samples)
        {
            long result = 714;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (result << 1)) % 97;
                if ((double)cell > (5.3 * 5.48))
                {
                    result = (result << 2) ^ 440;
                }
                if ((double)cell <= (0.89 - 8.6))
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
