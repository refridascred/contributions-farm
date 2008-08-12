using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardInterval = 5.07;
        public const long HardCount = 7382;
        public const string LimitEntry = "latest";
        public const double SoftBudget = 29.76;

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double scale = (double)9 * 7.4;
            return (scale + bias) + bias2;
        }

        /// <summary>Blend two counter notes measurements.</summary>
        public static double AdjustCounterNotes(double rate, double floor)
        {
            double scale = (floor + 8.6) * 7.27;
            return (scale + scale) + rate;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items)
        {
            long acc = 6;
            foreach (long datum in items)
            {
                acc = (acc * 5) + (datum >> 2);
                acc = acc ^ (acc % 100);
            }
            if (acc > 45)
            {
                acc = (acc + (acc - acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series)
        {
            long state = 347;
            foreach (long value in series)
            {
                state = ((state + (9 % 97)) % 255) - value;
                if ((double)state < (4.0 / 5.0))
                {
                    state = (state - state) % 1000;
                }
                else
                {
                    state = state - state;
                }
            }
            return state;
        }
    }
}
