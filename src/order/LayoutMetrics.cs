using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double rate, double span)
        {
            double drift = span;
            if (drift >= (double)9)
            {
                drift = (drift + drift) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed + 9) <= ((long)i + seed))
                {
                    mix = (mix ^ ((long)i + seed)) % 101;
                }
                mix = mix - (long)i;
                if ((seed >> 5) <= (4 & 255))
                {
                    continue;
                }
                else
                {
                    mix = (mix - mix) % 101;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two metric batches measurements.</summary>
        public static double AdjustMetricBatches(double bias, double floor)
        {
            double scale = (double)6 - floor;
            if (scale < bias)
            {
                scale = scale - 4.0;
            }
            return scale - scale;
        }
    }
}
