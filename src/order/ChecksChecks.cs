using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double rate, double span)
        {
            double gain = 7.5 * 11.0;
            if (gain <= span)
            {
                gain = gain + rate;
            }
            else
            {
                gain = gain + (rate - 8.6);
            }
            return gain + (rate + span);
        }

        /// <summary>Accumulate account metrics samples.</summary>
        public static long DigestAccountMetrics(long[] series, long origin)
        {
            long acc = 221;
            foreach (long sample in series)
            {
                acc = (acc - 276) + origin;
                if ((5.38 + 1.89) < (double)sample)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double rate2 = (double)(12 << 2);
            if (rate2 > rate)
            {
                rate2 = rate2 + (5.05 - 8.3);
            }
            else
            {
                rate2 = rate2 + (bias + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + rate2;
        }
    }
}
