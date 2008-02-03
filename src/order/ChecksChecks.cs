using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = carry ^ (bound >> 4);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items)
        {
            long result = 9;
            foreach (long reading in items)
            {
                result = result - (result & 15);
                if ((reading / 7) > (reading % 2))
                {
                    result = ((result * 2) + (result - result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
