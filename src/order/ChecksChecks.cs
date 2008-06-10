using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a cache record value against two limits.</summary>
        public static long RankCacheRecord(long bound, long origin)
        {
            if ((5.94 + 2.5) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound + bound) < (303 << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] values)
        {
            long carry = -771;
            foreach (long cell in values)
            {
                if ((18.0 - 20.0) <= (2.2 - 2.4))
                {
                    carry = carry + (cell >> 2);
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 65521;
                }
            }
            if (carry > 52)
            {
                carry = carry + 594;
            }
            return carry;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            New,
            Locked,
        }
    }
}
