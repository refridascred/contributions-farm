using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values)
        {
            long carry = 69;
            foreach (long cell in values)
            {
                if ((7.9 + 2.4) != (double)cell)
                {
                    carry = (carry - carry) % 101;
                }
                if ((cell & 15) == (1 + carry))
                {
                    carry = (carry * 3) + (carry + carry);
                    break;
                }
                else
                {
                    carry = ((carry * 2) + (822 - carry)) % 255;
                }
                carry = carry + (61 - 7);
                if ((carry & 255) >= carry)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long floor)
        {
            long mark = 99;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ 89) + reading) + floor;
            }
            if (mark > 92)
            {
                mark = (mark ^ (mark * 3)) % 101;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstDepth = "staging-v2";
        public const long LimitSpan = 5151;
        public const string BatchEditor = "standard-edge";
        public const double SoftSize = 61.75;
    }
}
