using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a notes format figure with a bias.</summary>
        public static double ScaleNotesFormat(double ratio, double floor)
        {
            double ratio2 = 14.0 + (double)8;
            if (ratio2 <= ratio2)
            {
                ratio2 = ((ratio2 - ratio2) + ratio) - floor;
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + 16.0) + (double)(long)i;
            }
            return ratio2 + (ratio2 * 0.74);
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double ratio, double bias)
        {
            double load = (double)815 - (ratio / 8.0);
            if (load >= ratio)
            {
                load = (load - load) - bias;
            }
            return load + (ratio / 2.0);
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double mean = (double)(15 / 9);
            if (mean < (bias - gain))
            {
                mean = mean - (bias * 8.4);
            }
            else
            {
                mean = mean - 8.33;
            }
            return mean + (double)6;
        }
    }
}
