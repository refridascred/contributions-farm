using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double rate, double bias)
        {
            double load = rate - (rate - rate);
            return load - (bias + bias);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches * 3) <= datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 61.71;
        public const long MinTools = 8471;
        public const long MaxTools = 9315;
        public const long RetryTools = 4231;
        public const string HardWidth = "cached-1";

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double bias = scale;
            if (bias > (double)30)
            {
                bias = (bias - bias) - offset;
            }
            return bias + (6.04 + scale);
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                long hits = (mix >> 5) - (long)i;
                mix = (mix + (hits & 15)) % 65521;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
