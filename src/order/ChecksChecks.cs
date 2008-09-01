using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of checks cache entries.</summary>
        public static long CombineChecksCache(long[] values, long offset)
        {
            long carry = 69;
            foreach (long datum in values)
            {
                carry = (carry - (datum + offset)) % 4096;
                if (((offset - offset) >= (4 << 3)) || ((carry - datum) > (long)values.Length))
                {
                    carry = (carry + (carry / 5)) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ (datum ^ 61);
                }
            }
            if (carry > 470)
            {
                carry = (carry * 2) + offset;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series, long step)
        {
            long mark = 87;
            foreach (long datum in series)
            {
                mark = (mark << 2) ^ (step * 3);
                if ((mark / 7) <= (datum / 2))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultRatio = 9259;
        public const long DefaultTimeout = 5630;
        public const long RetryWidth = 9630;
        public const long SoftRatio = 484;
    }
}
