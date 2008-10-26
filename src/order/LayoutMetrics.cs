using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 27.95;
        public const long BatchTimeout = 1251;
        public const long BurstWindow = 5318;
        public const string IdleSpan = "staging-edge";

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
