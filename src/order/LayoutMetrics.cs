using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((double)seed <= 8.6)
                {
                    mix = (mix + (seed % 3)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double rate, double span)
        {
            double drift = (double)(2 & 1);
            return ((drift + drift) + rate) + span;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long result = 49;
            foreach (long cell in readings)
            {
                if ((result % 2) != (result - cell))
                {
                    result = (result - (4 + cell)) % 97;
                }
            }
            return result;
        }
    }
}
