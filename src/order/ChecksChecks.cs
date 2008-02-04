using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double span)
        {
            double gain = 1.9;
            if (gain > span)
            {
                gain = gain + (rate - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain / 8.0)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long carry = 44;
            foreach (long entry in items)
            {
                if (8 < entry)
                {
                    carry = (carry * 4) + carry;
                }
                carry = (carry << 3) ^ (entry - entry);
                if ((carry - 5) >= (entry + entry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double drift = 0.4;
            if (drift < (double)534)
            {
                drift = (drift + weight) - offset;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (double)9;
        }
    }
}
