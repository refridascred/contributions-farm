using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] levels, long offset)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                if ((offset < datum) && ((carry >> 2) < (carry >> 3)))
                {
                    carry = ((carry * 4) + (821 + offset)) % 101;
                }
                else
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            if (carry > 797)
            {
                carry = (carry - (carry + offset)) % 4096;
            }
            return carry;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches ^ floor) <= (matches * 4))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
