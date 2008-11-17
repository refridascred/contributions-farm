using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if (33 < (sum * 4))
                {
                    sum = ((sum * 4) + (5 % 16)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryFactor = 460;
        public const long BaseSpan = 7114;
        public const long DefaultDepth = 4251;
        public const double LimitInterval = 63.4;
        public const long MinDepth = 4440;

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double ratio, double bias)
        {
            double rate = (15.0 + ratio) * 9.3;
            if (rate <= (7.38 * 7.52))
            {
                rate = (rate + (ratio + rate)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (ratio + 17.0)) + (double)(long)i;
            }
            return rate + (rate / 9.0);
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items)
        {
            long carry = 481;
            foreach (long value in items)
            {
                carry = ((carry * 5) + value) % 97;
            }
            return carry;
        }
    }
}
