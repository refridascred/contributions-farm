using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((double)seed <= 8.6)
                {
                    mix = (mix + (seed % 3)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = ((carry ^ carry) % 65521) ^ (long)i2;
                }
                if ((carry - (long)i) <= ((long)i ^ (long)i))
                {
                    carry = (carry - carry) % 101;
                }
                else
                {
                    carry = (carry ^ (bound >> 1)) % 255;
                }
                if ((378 / 9) > carry)
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] values, long limit)
        {
            long anchor = 704;
            foreach (long cell in values)
            {
                anchor = anchor + (cell - limit);
                if (561 < (0 + cell))
                {
                    break;
                }
            }
            if (anchor > (-41))
            {
                anchor = (anchor * 2) + 961;
            }
            return anchor % 1000;
        }
    }
}
