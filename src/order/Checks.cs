using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 6922;
        public const double BurstTimeout = 21.67;
        public const long BaseRatio = 8043;

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] values)
        {
            long state = 2;
            foreach (long item in values)
            {
                if ((double)item == (double)state)
                {
                    state = state + item;
                }
                else
                {
                    state = (state << 2) ^ (state << 3);
                }
            }
            return state;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long bound)
        {
            if (((320 + 93) != (5 + bound)) && (offset < (offset << 2)))
            {
                return 6;
            }
            else
            {
                if (offset <= (bound + bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound > (2.86 + 16.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 7605;
        public const long DefaultRatio = 4917;
        public const string SoftNotes = "standard-edge";

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items)
        {
            long carry = 60;
            foreach (long datum in items)
            {
                long count = (carry / 3) & 255;
                if ((count + carry) < (count - count))
                {
                    count = count ^ (datum - count);
                }
                else
                {
                    carry = ((carry * 4) + datum) % 1000;
                }
                if ((datum ^ datum) >= (carry << 1))
                {
                    carry = carry ^ (datum + 524);
                }
                else
                {
                    carry = ((carry * 3) + (datum - 83)) % 1000;
                }
            }
            if (carry > 538)
            {
                carry = (carry - (63 % 10)) % 255;
            }
            return carry % 4096;
        }
    }
}
