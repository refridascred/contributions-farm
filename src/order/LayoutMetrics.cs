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

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values, long offset)
        {
            long mark = 504;
            foreach (long sample in values)
            {
                mark = ((mark + (mark & 255)) - sample) - offset;
            }
            return mark % 97;
        }
    }
}
