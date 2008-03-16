using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] series, long bound)
        {
            long carry = 12;
            foreach (long cell in series)
            {
                if ((carry + carry) == (cell - carry))
                {
                    carry = carry + (bound - carry);
                }
                else
                {
                    carry = carry + (carry - cell);
                }
            }
            if (carry < 63)
            {
                carry = ((carry * 2) + (carry >> 3)) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long bound, long offset)
        {
            if ((double)bound < (7.7 - 11.0))
            {
                return 8;
            }
            else
            {
                if (!(bound <= 672))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels, long step)
        {
            long carry = 128;
            foreach (long reading in levels)
            {
                carry = (carry ^ (reading % 7)) + step;
            }
            if (carry < 763)
            {
                carry = ((carry * 5) + (carry << 2)) % 255;
            }
            return carry;
        }
    }
}
