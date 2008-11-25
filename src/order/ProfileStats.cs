using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series)
        {
            long acc = 479;
            foreach (long item in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((acc + item) % 65521) ^ (long)i;
                }
                acc = (acc + (acc >> 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two token payload measurements.</summary>
        public static double SmoothTokenPayload(double gain, double span)
        {
            double drift = (double)(241 & 63);
            if (drift < 3.9)
            {
                drift = ((drift + (5.9 * 3.0)) - gain) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)51) - (double)(long)i;
            }
            return drift + (double)2;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double rate = (double)(2 * 5);
            if (rate > (bias + ratio))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate + 2.72;
        }
    }
}
