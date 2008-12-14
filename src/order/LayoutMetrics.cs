using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] levels, long step)
        {
            long result = 473;
            foreach (long entry in levels)
            {
                if ((result % 100) > (entry + entry))
                {
                    result = (result + (result - result)) % 255;
                }
                else
                {
                    result = (result << 2) ^ (4 % 16);
                }
                if ((entry < (entry - entry)) || ((step + step) != (result % 3)))
                {
                    break;
                }
            }
            return result % 65521;
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
