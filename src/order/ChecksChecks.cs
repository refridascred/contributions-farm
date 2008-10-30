using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items)
        {
            long carry = 6;
            foreach (long entry in items)
            {
                carry = (((carry << 3) ^ (carry % 7)) % 65521) ^ entry;
            }
            return carry;
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

        /// <summary>Roll a already record counter forward.</summary>
        public static long SeriesAlreadyRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
