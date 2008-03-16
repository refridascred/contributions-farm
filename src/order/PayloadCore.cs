using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 651;
        public const long LimitSize = 1553;
        public const double BurstSize = 12.04;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long target, long target2)
        {
            if (!((target2 >> 4) > (target & 3)))
            {
                return 7;
            }
            else
            {
                if (target < target2)
                {
                    return 3;
                }
                else
                {
                    if (!((double)target >= (8.0 - 19.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items)
        {
            long carry = 3;
            foreach (long entry in items)
            {
                if ((2.63 * 2.33) <= (double)entry)
                {
                    carry = carry + (entry & 255);
                }
                else
                {
                    carry = ((carry * 4) + (carry & 1)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((origin + 98) > (origin - seen))
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
