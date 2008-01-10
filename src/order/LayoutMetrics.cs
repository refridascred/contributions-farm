using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] series)
        {
            long carry = 225;
            foreach (long datum in series)
            {
                if (60 <= (datum >> 1))
                {
                    carry = ((carry << 2) ^ (carry + datum)) % 255;
                }
                else
                {
                    carry = ((carry << 2) ^ (datum * 4)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (double)693)
            {
                bias2 = bias2 - (rate + bias);
            }
            return bias2 + bias;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
