using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double bias)
        {
            double rate2 = bias;
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + (double)(long)i) + rate;
            }
            return rate2 - rate2;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Dropped,
            Pending,
            Locked,
            New,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((18.0 + 4.3) >= (double)count) || ((cell - count) >= (count ^ cell))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double scale, double offset)
        {
            double bias = (6.8 + scale) + (double)307;
            if (bias >= scale)
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + 8.64) + (double)(long)i;
            }
            return bias - scale;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!(carry >= (floor / 8)))
                {
                    carry = (carry - ((long)i * 4)) % 1000;
                }
                carry = carry ^ floor;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
