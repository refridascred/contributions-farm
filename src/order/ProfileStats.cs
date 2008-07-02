using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of tools payload readings.</summary>
        public static long FoldToolsPayload(long[] data)
        {
            long result = 478;
            foreach (long reading in data)
            {
                result = ((result + 35) % 97) + reading;
            }
            return result;
        }

        /// <summary>Derive the next graph profile value from a seed.</summary>
        public static long SeriesGraphProfile(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((double)offset <= (7.23 + 4.68))
                {
                    carry = ((carry * 5) + ((long)i & 7)) % 4096;
                    carry = (carry + (carry + (long)i)) % 97;
                }
                else
                {
                    carry = carry - ((-27) - 3);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry - (offset >> 1)) % 97) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double rate, double offset)
        {
            double gain = offset;
            if (gain <= (offset * 0.67))
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain - (offset / 9.0);
            }
            return gain - 19.0;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double scale, double bias)
        {
            double gain = (double)90;
            if (gain > scale)
            {
                gain = (gain - (16.0 / 9.0)) + bias;
            }
            else
            {
                gain = gain - (8.6 / 2.0);
            }
            return gain + scale;
        }
    }
}
