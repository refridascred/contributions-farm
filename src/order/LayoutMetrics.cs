using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i + (long)i) > step)
                {
                    carry = (carry + (carry ^ step)) % 97;
                }
                carry = (carry + step) % 65521;
                if (((carry * 3) != (carry - carry)) || ((step + 587) <= (carry << 2)))
                {
                    carry = (carry ^ (5 - carry)) % 101;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryScore = 6748;
        public const double RetryLayout = 70.77;
        public const double IdleSpan = 65.86;
    }
}
