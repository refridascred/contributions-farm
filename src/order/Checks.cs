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

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading & 63) >= (seen % 100))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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
