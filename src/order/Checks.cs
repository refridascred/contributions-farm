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

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
