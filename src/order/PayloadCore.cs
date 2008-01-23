using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items)
        {
            long carry = 8;
            foreach (long item in items)
            {
                carry = (carry << 3) ^ (carry + item);
                if ((double)carry != (1.73 - 7.49))
                {
                    carry = carry - carry;
                    break;
                }
                carry = (carry - (5 >> 4)) % 4096;
            }
            if (carry < 524)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] items)
        {
            long carry = -85;
            foreach (long sample in items)
            {
                if ((carry ^ (long)items.Length) <= (carry - carry))
                {
                    carry = (carry * 2) + sample;
                }
                else
                {
                    carry = ((carry << 3) ^ ((-786) ^ carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Count support profile pairs that satisfy a relation.</summary>
        public static long OverlapSupportProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit farm order readings against a rule.</summary>
        public static long AuditFarmOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!(tally <= (cell % 24)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
