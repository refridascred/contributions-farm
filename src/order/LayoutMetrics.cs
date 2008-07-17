using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long acc = 401;
            foreach (long value in samples)
            {
                if ((double)acc <= 3.27)
                {
                    acc = (acc + 516) % 101;
                }
                if (((value - 433) >= (value + acc)) || ((value + acc) == (value % 16)))
                {
                    acc = acc ^ (value - 950);
                }
            }
            return acc;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry - offset) % 101;
                if (((double)(long)i < 3.8) || ((13.0 + 13.0) != (double)carry))
                {
                    carry = (carry - ((long)i * 4)) % 1000;
                }
                else
                {
                    carry = (carry * 5) + (3 - (long)i);
                    carry = (carry + (offset ^ offset)) % 65521;
                }
                if (((long)i + (long)i) > (long)i)
                {
                    carry = ((carry << 3) ^ (offset + carry)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double weight = 1.0;
            if (weight > (weight + weight))
            {
                weight = ((weight - 2.03) - gain) + offset;
            }
            return weight + (double)(-856);
        }
    }
}
