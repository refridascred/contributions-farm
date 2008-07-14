using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double ratio = gain - (double)364;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + (1.19 * 5.4)) + (double)(long)i) + offset;
            }
            return ratio + (double)2;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((seed - carry) < seed)
                {
                    carry = carry + ((long)i + seed);
                    carry = (carry - ((long)i + carry)) % 4096;
                    continue;
                }
                if (((5 / 6) != (seed & 255)) || ((double)carry != (5.9 - 1.0)))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
