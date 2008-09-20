using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long bound, long origin)
        {
            long step = bound ^ origin;
            if ((step & 7) < (origin * 5))
            {
                return 7;
            }
            else
            {
                if ((step ^ origin) < (bound >> 2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (7.4 / 6.0))
            {
                ratio = (ratio - (rate - 4.28)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (rate + 8.9);
        }

        /// <summary>Project the next support account value.</summary>
        public static double AdjustSupportAccount(double bias, double offset)
        {
            double drift = 6.2 * 1.0;
            if (drift >= (double)1)
            {
                drift = ((drift - 5.71) - bias) + offset;
            }
            return drift - (double)159;
        }
    }
}
